namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Computers
    {

        private string[] operatingSystemField;

        private bool hasFrontFacingCameraField;

        private bool hasFrontFacingCameraFieldSpecified;

        private string graphicsInformationField;

        private string opticalDriveField;

        private string formFactorField;

        private bool hasTouchscreenField;

        private bool hasTouchscreenFieldSpecified;

        private string resolutionField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private ResolutionUnit frontFacingCameraMegapixelsField;

        private ResolutionUnit rearCameraMegapixelsField;

        private DigitalCapacityUnit hardDriveCapacityField;

        private DigitalCapacityUnit maximumRamSupportedField;

        private FrequencyUnit processorSpeedField;

        private string[] processorTypeField;

        private DigitalCapacityUnit ramMemoryField;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("operatingSystemValue", IsNullable = false)]
        public string[] operatingSystem
        {
            get
            {
                return this.operatingSystemField;
            }
            set
            {
                this.operatingSystemField = value;
            }
        }

        /// <remarks/>
        public bool hasFrontFacingCamera
        {
            get
            {
                return this.hasFrontFacingCameraField;
            }
            set
            {
                this.hasFrontFacingCameraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasFrontFacingCameraSpecified
        {
            get
            {
                return this.hasFrontFacingCameraFieldSpecified;
            }
            set
            {
                this.hasFrontFacingCameraFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string graphicsInformation
        {
            get
            {
                return this.graphicsInformationField;
            }
            set
            {
                this.graphicsInformationField = value;
            }
        }

        /// <remarks/>
        public string opticalDrive
        {
            get
            {
                return this.opticalDriveField;
            }
            set
            {
                this.opticalDriveField = value;
            }
        }

        /// <remarks/>
        public string formFactor
        {
            get
            {
                return this.formFactorField;
            }
            set
            {
                this.formFactorField = value;
            }
        }

        /// <remarks/>
        public bool hasTouchscreen
        {
            get
            {
                return this.hasTouchscreenField;
            }
            set
            {
                this.hasTouchscreenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTouchscreenSpecified
        {
            get
            {
                return this.hasTouchscreenFieldSpecified;
            }
            set
            {
                this.hasTouchscreenFieldSpecified = value;
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