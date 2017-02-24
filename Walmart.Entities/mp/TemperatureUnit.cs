namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class TemperatureUnit
    {

        private TemperatureUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        /// <remarks/>
        public TemperatureUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }
}