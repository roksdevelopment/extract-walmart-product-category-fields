namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MainImage
    {

        private string mainImageUrlField;

        private string altTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string mainImageUrl
        {
            get
            {
                return this.mainImageUrlField;
            }
            set
            {
                this.mainImageUrlField = value;
            }
        }

        /// <remarks/>
        public string altText
        {
            get
            {
                return this.altTextField;
            }
            set
            {
                this.altTextField = value;
            }
        }
    }
}