namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class InstrumentAccessories
    {

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string[] patternField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private string[] instrumentField;

        private inputsAndOutput[] inputsAndOutputsField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public string[] pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        /// <remarks/>
        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("instrumentValue", IsNullable = false)]
        public string[] instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public inputsAndOutput[] inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        /// <remarks/>
        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        /// <remarks/>
        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
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