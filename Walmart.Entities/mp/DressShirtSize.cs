namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class DressShirtSize
    {

        private decimal neckSizeField;

        private decimal sleeveLengthField;

        private bool sleeveLengthFieldSpecified;

        /// <remarks/>
        public decimal neckSize
        {
            get
            {
                return this.neckSizeField;
            }
            set
            {
                this.neckSizeField = value;
            }
        }

        /// <remarks/>
        public decimal sleeveLength
        {
            get
            {
                return this.sleeveLengthField;
            }
            set
            {
                this.sleeveLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sleeveLengthSpecified
        {
            get
            {
                return this.sleeveLengthFieldSpecified;
            }
            set
            {
                this.sleeveLengthFieldSpecified = value;
            }
        }
    }
}