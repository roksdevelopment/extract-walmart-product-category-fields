namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BraSize
    {

        private decimal braBandSizeField;

        private bool braBandSizeFieldSpecified;

        private string braCupSizeField;

        /// <remarks/>
        public decimal braBandSize
        {
            get
            {
                return this.braBandSizeField;
            }
            set
            {
                this.braBandSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool braBandSizeSpecified
        {
            get
            {
                return this.braBandSizeFieldSpecified;
            }
            set
            {
                this.braBandSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string braCupSize
        {
            get
            {
                return this.braCupSizeField;
            }
            set
            {
                this.braCupSizeField = value;
            }
        }
    }
}