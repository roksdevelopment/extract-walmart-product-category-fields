namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class CellPhones
    {

        private string cellPhoneTypeField;

        private string resolutionField;

        private LengthUnit screenSizeField;

        private string[] mobileOperatingSystemField;

        private string modelNameField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private string cellPhoneServiceProviderField;

        private string cellularNetworkTechnologyField;

        private ResolutionUnit frontFacingCameraMegapixelsField;

        private bool hasFlashField;

        private bool hasFlashFieldSpecified;

        private TimeUnit standbyTimeField;

        private TimeUnit talkTimeField;

        private ResolutionUnit rearCameraMegapixelsField;

        private DigitalCapacityUnit maximumRamSupportedField;

        private FrequencyUnit processorSpeedField;

        private string[] processorTypeField;

        private DigitalCapacityUnit ramMemoryField;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        public string cellPhoneType
        {
            get
            {
                return this.cellPhoneTypeField;
            }
            set
            {
                this.cellPhoneTypeField = value;
            }
        }

        /// <remarks/>
        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        /// <remarks/>
        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("mobileOperatingSystemValue", IsNullable = false)]
        public string[] mobileOperatingSystem
        {
            get
            {
                return this.mobileOperatingSystemField;
            }
            set
            {
                this.mobileOperatingSystemField = value;
            }
        }

        /// <remarks/>
        public string modelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
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
        public string cellPhoneServiceProvider
        {
            get
            {
                return this.cellPhoneServiceProviderField;
            }
            set
            {
                this.cellPhoneServiceProviderField = value;
            }
        }

        /// <remarks/>
        public string cellularNetworkTechnology
        {
            get
            {
                return this.cellularNetworkTechnologyField;
            }
            set
            {
                this.cellularNetworkTechnologyField = value;
            }
        }

        /// <remarks/>
        public ResolutionUnit frontFacingCameraMegapixels
        {
            get
            {
                return this.frontFacingCameraMegapixelsField;
            }
            set
            {
                this.frontFacingCameraMegapixelsField = value;
            }
        }

        /// <remarks/>
        public bool hasFlash
        {
            get
            {
                return this.hasFlashField;
            }
            set
            {
                this.hasFlashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasFlashSpecified
        {
            get
            {
                return this.hasFlashFieldSpecified;
            }
            set
            {
                this.hasFlashFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeUnit standbyTime
        {
            get
            {
                return this.standbyTimeField;
            }
            set
            {
                this.standbyTimeField = value;
            }
        }

        /// <remarks/>
        public TimeUnit talkTime
        {
            get
            {
                return this.talkTimeField;
            }
            set
            {
                this.talkTimeField = value;
            }
        }

        /// <remarks/>
        public ResolutionUnit rearCameraMegapixels
        {
            get
            {
                return this.rearCameraMegapixelsField;
            }
            set
            {
                this.rearCameraMegapixelsField = value;
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