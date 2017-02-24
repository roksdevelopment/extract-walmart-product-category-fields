namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class fabricContentValue
    {

        private string materialNameField;

        private decimal materialPercentageField;

        private bool materialPercentageFieldSpecified;

        /// <remarks/>
        public string materialName
        {
            get
            {
                return this.materialNameField;
            }
            set
            {
                this.materialNameField = value;
            }
        }

        /// <remarks/>
        public decimal materialPercentage
        {
            get
            {
                return this.materialPercentageField;
            }
            set
            {
                this.materialPercentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool materialPercentageSpecified
        {
            get
            {
                return this.materialPercentageFieldSpecified;
            }
            set
            {
                this.materialPercentageFieldSpecified = value;
            }
        }
    }
}