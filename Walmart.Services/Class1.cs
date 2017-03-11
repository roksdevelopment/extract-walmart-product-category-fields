/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Walmart.Services
{
    [XmlRoot(ElementName = "include", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Include
    {
        [XmlAttribute(AttributeName = "schemaLocation")]
        public string SchemaLocation { get; set; }
    }

    [XmlRoot(ElementName = "requiredLevel", Namespace = "http://walmart.com/")]
    public class RequiredLevel
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "appinfo", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Appinfo
    {
        public string RequiredLevel { get; set; }

        [XmlElement(ElementName = "conditionalAttributes", Namespace = "http://walmart.com/")]
        public ConditionalAttributes ConditionalAttributes { get; set; }
    }

    [XmlRoot(ElementName = "annotation", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Annotation
    {
        [XmlElement(ElementName = "appinfo", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Appinfo Appinfo { get; set; }

        // not valid with inner <p> tags
        [XmlElement(ElementName = "documentation", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public string Documentation { get; set; }
    }

    [XmlRoot(ElementName = "maxLength", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class MaxLength
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "restriction", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Restriction
    {
        [XmlElement(ElementName = "maxLength", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public MaxLength MaxLength { get; set; }
        [XmlAttribute(AttributeName = "base")]
        public string Base { get; set; }
    }

    [XmlRoot(ElementName = "simpleType", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class SimpleType
    {
        [XmlElement(ElementName = "restriction", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Restriction Restriction { get; set; }
    }

    [XmlRoot(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Element
    {
        [XmlElement(ElementName = "annotation", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Annotation Annotation { get; set; }
        [XmlElement(ElementName = "simpleType", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public SimpleType SimpleType { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "minOccurs")]
        public string MinOccurs { get; set; }
        [XmlAttribute(AttributeName = "maxOccurs")]
        public string MaxOccurs { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Sequence
    {
        [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public List<Element> Element { get; set; }
        [XmlElement(ElementName = "choice", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Choice Choice { get; set; }
    }

    [XmlRoot(ElementName = "complexType", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class ComplexType
    {
        [XmlElement(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Sequence Sequence { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "conditionalAttribute", Namespace = "http://walmart.com/")]
    public class ConditionalAttribute
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "conditionalAttributes", Namespace = "http://walmart.com/")]
    public class ConditionalAttributes
    {
        [XmlElement(ElementName = "conditionalAttribute", Namespace = "http://walmart.com/")]
        public List<ConditionalAttribute> ConditionalAttribute { get; set; }
    }

    [XmlRoot(ElementName = "choice", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Choice
    {
        [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public List<Element> Element { get; set; }
        [XmlAttribute(AttributeName = "minOccurs")]
        public string MinOccurs { get; set; }
        [XmlAttribute(AttributeName = "maxOccurs")]
        public string MaxOccurs { get; set; }
    }

    [XmlRoot(ElementName = "schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Schema
    {
        [XmlElement(ElementName = "include", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Include Include { get; set; }
        [XmlElement(ElementName = "complexType", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public List<ComplexType> ComplexType { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "targetNamespace")]
        public string TargetNamespace { get; set; }
        [XmlAttribute(AttributeName = "elementFormDefault")]
        public string ElementFormDefault { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }


    [XmlRoot(ElementName = "documentation", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Documentation
    {
    
        public string S { get; set; }
        //[XmlElement(ElementName = "p", Namespace = "http://walmart.com/")]
        //public List<string> P { get; set; }
    }

    [XmlRoot(ElementName = "enumeration", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Enumeration
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }
    

    }


