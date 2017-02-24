namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class WheelsAndWheelComponents
    {

        private string finishField;

        private LengthUnit diameterField;

        private decimal vehicleRimSizeField;

        private bool vehicleRimSizeFieldSpecified;

        private decimal compatibleTireSizeField;

        private bool compatibleTireSizeFieldSpecified;

        private string numberOfSpokesField;

        private bool hasWearSensorField;

        private bool hasWearSensorFieldSpecified;

        /// <remarks/>
        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        /// <remarks/>
        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        /// <remarks/>
        public decimal vehicleRimSize
        {
            get
            {
                return this.vehicleRimSizeField;
            }
            set
            {
                this.vehicleRimSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vehicleRimSizeSpecified
        {
            get
            {
                return this.vehicleRimSizeFieldSpecified;
            }
            set
            {
                this.vehicleRimSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal compatibleTireSize
        {
            get
            {
                return this.compatibleTireSizeField;
            }
            set
            {
                this.compatibleTireSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compatibleTireSizeSpecified
        {
            get
            {
                return this.compatibleTireSizeFieldSpecified;
            }
            set
            {
                this.compatibleTireSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfSpokes
        {
            get
            {
                return this.numberOfSpokesField;
            }
            set
            {
                this.numberOfSpokesField = value;
            }
        }

        /// <remarks/>
        public bool hasWearSensor
        {
            get
            {
                return this.hasWearSensorField;
            }
            set
            {
                this.hasWearSensorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWearSensorSpecified
        {
            get
            {
                return this.hasWearSensorFieldSpecified;
            }
            set
            {
                this.hasWearSensorFieldSpecified = value;
            }
        }
    }
}