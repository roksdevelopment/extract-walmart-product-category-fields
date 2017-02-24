namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class additionalProductAttribute
    {

        private string productAttributeNameField;

        private string productAttributeValueField;

        /// <remarks/>
        public string productAttributeName
        {
            get
            {
                return this.productAttributeNameField;
            }
            set
            {
                this.productAttributeNameField = value;
            }
        }

        /// <remarks/>
        public string productAttributeValue
        {
            get
            {
                return this.productAttributeValueField;
            }
            set
            {
                this.productAttributeValueField = value;
            }
        }
    }
}