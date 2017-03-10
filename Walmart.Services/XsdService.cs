
using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Walmart.Services
{
    public class XsdService : IXsdService
    {
        private string _folderWithXsds;

        public XsdService(string folderWithXsds)
        {
            _folderWithXsds = folderWithXsds;
        }

        public object GetInfo(string xsdName)
        {
            var fileName = $"{xsdName.Split('.').First()}.xsd";

           var file = Path.Combine(_folderWithXsds, fileName);

            if (!File.Exists(file))
            {
                throw new InvalidOperationException($"XSD does not exists in such folder.");
            }

            using (var reader = new StringReader(File.ReadAllText(file)))
            {
                var ser = new XmlSerializer(typeof(Schema));
                var schema = ser.Deserialize(reader) as Schema;
                return schema;
            }
        }
    }

    public interface IXsdService
    {
        object GetInfo(string xsdName);
    }
}
