namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class AnimalAccessories
    {

        private string conditionField;

        private TemperatureUnit minimumTemperatureField;

        private string clothingSizeField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string[] characterField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool isReflectiveField;

        private bool isReflectiveFieldSpecified;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private TemperatureUnit maximumTemperatureField;

        private string capacityField;

        private string shapeField;

        /// <remarks/>
        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        public TemperatureUnit minimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        /// <remarks/>
        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        /// <remarks/>
        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public string[] character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        /// <remarks/>
        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isReflective
        {
            get
            {
                return this.isReflectiveField;
            }
            set
            {
                this.isReflectiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReflectiveSpecified
        {
            get
            {
                return this.isReflectiveFieldSpecified;
            }
            set
            {
                this.isReflectiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TemperatureUnit maximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }

        /// <remarks/>
        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        /// <remarks/>
        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }
}