namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class swatchImage
    {

        private string swatchImageUrlField;

        private string swatchVariantAttributeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string swatchImageUrl
        {
            get
            {
                return this.swatchImageUrlField;
            }
            set
            {
                this.swatchImageUrlField = value;
            }
        }

        /// <remarks/>
        public string swatchVariantAttribute
        {
            get
            {
                return this.swatchVariantAttributeField;
            }
            set
            {
                this.swatchVariantAttributeField = value;
            }
        }
    }
}