namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class trackListing
    {

        private string trackNumberField;

        private string trackNameField;

        private decimal trackDurationField;

        private bool trackDurationFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string trackNumber
        {
            get
            {
                return this.trackNumberField;
            }
            set
            {
                this.trackNumberField = value;
            }
        }

        /// <remarks/>
        public string trackName
        {
            get
            {
                return this.trackNameField;
            }
            set
            {
                this.trackNameField = value;
            }
        }

        /// <remarks/>
        public decimal trackDuration
        {
            get
            {
                return this.trackDurationField;
            }
            set
            {
                this.trackDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trackDurationSpecified
        {
            get
            {
                return this.trackDurationFieldSpecified;
            }
            set
            {
                this.trackDurationFieldSpecified = value;
            }
        }
    }
}