
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Walmart.Services
{
    public interface IXsdService
    {
        IReadOnlyList<CategoryInfo> GetInfo(string xsdName);
    }

    public class XsdService : IXsdService
    {
        private readonly string _folderWithXsds;

        public XsdService(string folderWithXsds)
        {
            _folderWithXsds = folderWithXsds;
        }

        public IReadOnlyList<CategoryInfo> GetInfo(string xsdName)
        {
            var fileName = $"{xsdName.Split('.').First()}.xsd";

            var file = Path.Combine(_folderWithXsds, fileName);

            if (!File.Exists(file))
            {
                throw new InvalidOperationException($"XSD does not exists in such folder.");
            }

            var xDoc = XDocument.Load(file);
            var ns = XNamespace.Get(@"http://www.w3.org/2001/XMLSchema");
            var nsW = XNamespace.Get(@"http://walmart.com/content");

            var schema = xDoc.Elements(ns + "schema");
            var includes = schema.Elements(ns + "include");
            var complexTypes = schema.Elements(ns + "complexType");

            var res = new List<CategoryInfo>();
            foreach (var complexType in complexTypes)
            {
                var attrs = complexType.Elements(ns + "all")
                    //.Elements(ns + "sequence")
                    //.Elements(ns + "element")
                    ;

                var cat = new CategoryInfo
                {
                    CategoryName = $"{xsdName}|{complexType.Attribute("name").Value}"
                };

                var attrInfos = new List<AttributeInfo>();
                foreach (var node in attrs.Elements(ns + "element"))
                {
                    var attributeInfo = new AttributeInfo
                    {
                        Name = node.Attribute("name")?.Value,
                        TypeName = node.Attribute("type")?.Value,
                        IsComplexType = node.Attribute("type") != null
                    };

                    var annotation = node.Element(ns + "annotation");

                    if (annotation != null)
                    {
                        var appinfoE = annotation.Element(ns + "appinfo");
                        var rl = appinfoE?.Element(nsW + "requiredLevel");
                        attributeInfo.Annotation = new Annotation
                        {
                            Appinfo = new Appinfo
                            {
                                RequiredLevel = rl?.Attribute("value")?.Value
                            },
                            Documentation = annotation.Element(ns + "documentation")?.Value
                                .Replace(Environment.NewLine, "").Replace('\n', ' ')
                        };
                    }

                    var simpleTypeE = node.Element(ns + "simpleType");

                    var restrictionE = simpleTypeE?.Element(ns + "restriction");

                    if (restrictionE != null)
                    {
                        var typeName = restrictionE.Attribute("base").Value.Replace("xsd:", "");
                        attributeInfo.TypeName = typeName;
                    }

                    attrInfos.Add(attributeInfo);
                }
                cat.Add(attrInfos);

                res.Add(cat);
            }

            return res;
        }
    }

    public class CategoryInfo
    {
        private readonly List<AttributeInfo> _attributeInfos;
        public IReadOnlyList<AttributeInfo> AttributeInfos => _attributeInfos;
        public string CategoryName { get; set; }

        public CategoryInfo()
        {
            _attributeInfos = new List<AttributeInfo>();
        }

        public void Add(List<AttributeInfo> attrInfos)
        {
            foreach (var attributeInfo in attrInfos)
            {
                _attributeInfos.Add(attributeInfo);
            }
        }
    }

    public class AttributeInfo
    {
        public string Name { get; set; }
        public Annotation Annotation { get; set; }
        public string TypeName { get; set; }
        public bool IsComplexType { get; set; }
    }


}
