namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class PlumbingAndHVAC
    {

        private bool isEnergyGuideLabelRequiredField;

        private bool isEnergyGuideLabelRequiredFieldSpecified;

        private string energyGuideLabelField;

        private string finishField;

        private string homeDecorStyleField;

        private string[] mountTypeField;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private string seatingCapacityField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private string btuField;

        private AreaUnit maximumRoomSizeField;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        private bool hasCeeCertificationField;

        private bool hasCeeCertificationFieldSpecified;

        private PlumbingAndHVACCeeTier ceeTierField;

        private bool ceeTierFieldSpecified;

        private string drainConfigurationField;

        private string faucetDrillingsField;

        private VolumeUnit gallonsPerFlushField;

        private VolumeUnit gallonsPerMinuteField;

        private string humidificationOutputPerDayField;

        private LengthUnit inletDiameterField;

        private string mervRatingField;

        private LengthUnit outletDiameterField;

        private string pintsOfMoistureRemovedPerDayField;

        private LengthUnit spoutHeightField;

        private LengthUnit spoutReachField;

        private LengthUnit spudInletSizeField;

        private string threadStandardField;

        private string toiletBowlSizeField;

        private string tripLeverPlacementField;

        private bool isVentedField;

        private bool isVentedFieldSpecified;

        private bool ventingRequiredField;

        private bool ventingRequiredFieldSpecified;

        private string humidificationMethodField;

        private PowerUnit horsepowerField;

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
        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public string[] mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
            }
        }

        /// <remarks/>
        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
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

        /// <remarks/>
        public bool hasCeeCertification
        {
            get
            {
                return this.hasCeeCertificationField;
            }
            set
            {
                this.hasCeeCertificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCeeCertificationSpecified
        {
            get
            {
                return this.hasCeeCertificationFieldSpecified;
            }
            set
            {
                this.hasCeeCertificationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PlumbingAndHVACCeeTier ceeTier
        {
            get
            {
                return this.ceeTierField;
            }
            set
            {
                this.ceeTierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ceeTierSpecified
        {
            get
            {
                return this.ceeTierFieldSpecified;
            }
            set
            {
                this.ceeTierFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string drainConfiguration
        {
            get
            {
                return this.drainConfigurationField;
            }
            set
            {
                this.drainConfigurationField = value;
            }
        }

        /// <remarks/>
        public string faucetDrillings
        {
            get
            {
                return this.faucetDrillingsField;
            }
            set
            {
                this.faucetDrillingsField = value;
            }
        }

        /// <remarks/>
        public VolumeUnit gallonsPerFlush
        {
            get
            {
                return this.gallonsPerFlushField;
            }
            set
            {
                this.gallonsPerFlushField = value;
            }
        }

        /// <remarks/>
        public VolumeUnit gallonsPerMinute
        {
            get
            {
                return this.gallonsPerMinuteField;
            }
            set
            {
                this.gallonsPerMinuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string humidificationOutputPerDay
        {
            get
            {
                return this.humidificationOutputPerDayField;
            }
            set
            {
                this.humidificationOutputPerDayField = value;
            }
        }

        /// <remarks/>
        public LengthUnit inletDiameter
        {
            get
            {
                return this.inletDiameterField;
            }
            set
            {
                this.inletDiameterField = value;
            }
        }

        /// <remarks/>
        public string mervRating
        {
            get
            {
                return this.mervRatingField;
            }
            set
            {
                this.mervRatingField = value;
            }
        }

        /// <remarks/>
        public LengthUnit outletDiameter
        {
            get
            {
                return this.outletDiameterField;
            }
            set
            {
                this.outletDiameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string pintsOfMoistureRemovedPerDay
        {
            get
            {
                return this.pintsOfMoistureRemovedPerDayField;
            }
            set
            {
                this.pintsOfMoistureRemovedPerDayField = value;
            }
        }

        /// <remarks/>
        public LengthUnit spoutHeight
        {
            get
            {
                return this.spoutHeightField;
            }
            set
            {
                this.spoutHeightField = value;
            }
        }

        /// <remarks/>
        public LengthUnit spoutReach
        {
            get
            {
                return this.spoutReachField;
            }
            set
            {
                this.spoutReachField = value;
            }
        }

        /// <remarks/>
        public LengthUnit spudInletSize
        {
            get
            {
                return this.spudInletSizeField;
            }
            set
            {
                this.spudInletSizeField = value;
            }
        }

        /// <remarks/>
        public string threadStandard
        {
            get
            {
                return this.threadStandardField;
            }
            set
            {
                this.threadStandardField = value;
            }
        }

        /// <remarks/>
        public string toiletBowlSize
        {
            get
            {
                return this.toiletBowlSizeField;
            }
            set
            {
                this.toiletBowlSizeField = value;
            }
        }

        /// <remarks/>
        public string tripLeverPlacement
        {
            get
            {
                return this.tripLeverPlacementField;
            }
            set
            {
                this.tripLeverPlacementField = value;
            }
        }

        /// <remarks/>
        public bool isVented
        {
            get
            {
                return this.isVentedField;
            }
            set
            {
                this.isVentedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVentedSpecified
        {
            get
            {
                return this.isVentedFieldSpecified;
            }
            set
            {
                this.isVentedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ventingRequired
        {
            get
            {
                return this.ventingRequiredField;
            }
            set
            {
                this.ventingRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ventingRequiredSpecified
        {
            get
            {
                return this.ventingRequiredFieldSpecified;
            }
            set
            {
                this.ventingRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string humidificationMethod
        {
            get
            {
                return this.humidificationMethodField;
            }
            set
            {
                this.humidificationMethodField = value;
            }
        }

        /// <remarks/>
        public PowerUnit horsepower
        {
            get
            {
                return this.horsepowerField;
            }
            set
            {
                this.horsepowerField = value;
            }
        }
    }
}