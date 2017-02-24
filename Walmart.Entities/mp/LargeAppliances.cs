namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class LargeAppliances
    {

        private bool isEnergyGuideLabelRequiredField;

        private bool isEnergyGuideLabelRequiredFieldSpecified;

        private string energyGuideLabelField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private bool hasCflField;

        private bool hasCflFieldSpecified;

        private bool isLightingFactsLabelRequiredField;

        private bool isLightingFactsLabelRequiredFieldSpecified;

        private string lightingFactsLabelField;

        private string capacityField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private string loadPositionField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private string btuField;

        private AreaUnit maximumRoomSizeField;

        private TimeUnit runTimeField;

        private LengthUnit cordLengthField;

        private bool isSmartField;

        private bool isSmartFieldSpecified;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        /// <remarks/>
        public bool isEnergyGuideLabelRequired
        {
            get
            {
                return this.isEnergyGuideLabelRequiredField;
            }
            set
            {
                this.isEnergyGuideLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyGuideLabelRequiredSpecified
        {
            get
            {
                return this.isEnergyGuideLabelRequiredFieldSpecified;
            }
            set
            {
                this.isEnergyGuideLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string energyGuideLabel
        {
            get
            {
                return this.energyGuideLabelField;
            }
            set
            {
                this.energyGuideLabelField = value;
            }
        }

        /// <remarks/>
        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
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
        public bool hasCfl
        {
            get
            {
                return this.hasCflField;
            }
            set
            {
                this.hasCflField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCflSpecified
        {
            get
            {
                return this.hasCflFieldSpecified;
            }
            set
            {
                this.hasCflFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isLightingFactsLabelRequired
        {
            get
            {
                return this.isLightingFactsLabelRequiredField;
            }
            set
            {
                this.isLightingFactsLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightingFactsLabelRequiredSpecified
        {
            get
            {
                return this.isLightingFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isLightingFactsLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string lightingFactsLabel
        {
            get
            {
                return this.lightingFactsLabelField;
            }
            set
            {
                this.lightingFactsLabelField = value;
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
        public VolumeUnit volumeCapacity
        {
            get
            {
                return this.volumeCapacityField;
            }
            set
            {
                this.volumeCapacityField = value;
            }
        }

        /// <remarks/>
        public string fuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        /// <remarks/>
        public string loadPosition
        {
            get
            {
                return this.loadPositionField;
            }
            set
            {
                this.loadPositionField = value;
            }
        }

        /// <remarks/>
        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        /// <remarks/>
        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string btu
        {
            get
            {
                return this.btuField;
            }
            set
            {
                this.btuField = value;
            }
        }

        /// <remarks/>
        public AreaUnit maximumRoomSize
        {
            get
            {
                return this.maximumRoomSizeField;
            }
            set
            {
                this.maximumRoomSizeField = value;
            }
        }

        /// <remarks/>
        public TimeUnit runTime
        {
            get
            {
                return this.runTimeField;
            }
            set
            {
                this.runTimeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit cordLength
        {
            get
            {
                return this.cordLengthField;
            }
            set
            {
                this.cordLengthField = value;
            }
        }

        /// <remarks/>
        public bool isSmart
        {
            get
            {
                return this.isSmartField;
            }
            set
            {
                this.isSmartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSmartSpecified
        {
            get
            {
                return this.isSmartFieldSpecified;
            }
            set
            {
                this.isSmartFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
            }
        }
    }
}