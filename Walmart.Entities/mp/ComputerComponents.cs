namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class ComputerComponents
    {

        private ComputerComponentsInternalExternal internalExternalField;

        private bool internalExternalFieldSpecified;

        private DigitalCapacityUnit hardDriveCapacityField;

        private string[] cpuSocketTypeField;

        private string[] motherboardFormFactorField;

        private DigitalCapacityUnit maximumRamSupportedField;

        private FrequencyUnit processorSpeedField;

        private string[] processorTypeField;

        private DigitalCapacityUnit ramMemoryField;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        public ComputerComponentsInternalExternal internalExternal
        {
            get
            {
                return this.internalExternalField;
            }
            set
            {
                this.internalExternalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool internalExternalSpecified
        {
            get
            {
                return this.internalExternalFieldSpecified;
            }
            set
            {
                this.internalExternalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DigitalCapacityUnit hardDriveCapacity
        {
            get
            {
                return this.hardDriveCapacityField;
            }
            set
            {
                this.hardDriveCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cpuSocketTypeValue", IsNullable = false)]
        public string[] cpuSocketType
        {
            get
            {
                return this.cpuSocketTypeField;
            }
            set
            {
                this.cpuSocketTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("motherboardFormFactorValue", IsNullable = false)]
        public string[] motherboardFormFactor
        {
            get
            {
                return this.motherboardFormFactorField;
            }
            set
            {
                this.motherboardFormFactorField = value;
            }
        }

        /// <remarks/>
        public DigitalCapacityUnit maximumRamSupported
        {
            get
            {
                return this.maximumRamSupportedField;
            }
            set
            {
                this.maximumRamSupportedField = value;
            }
        }

        /// <remarks/>
        public FrequencyUnit processorSpeed
        {
            get
            {
                return this.processorSpeedField;
            }
            set
            {
                this.processorSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("processorTypeValue", IsNullable = false)]
        public string[] processorType
        {
            get
            {
                return this.processorTypeField;
            }
            set
            {
                this.processorTypeField = value;
            }
        }

        /// <remarks/>
        public DigitalCapacityUnit ramMemory
        {
            get
            {
                return this.ramMemoryField;
            }
            set
            {
                this.ramMemoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public string[] wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }
}