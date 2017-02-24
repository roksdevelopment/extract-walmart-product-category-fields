namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Electrical
    {

        private string finishField;

        private string homeDecorStyleField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string[] mountTypeField;

        private string batterySizeField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private string[] patternField;

        private string[] characterField;

        private string powerTypeField;

        private LengthUnit diameterField;

        private bool hasCflField;

        private bool hasCflFieldSpecified;

        private bool isLightingFactsLabelRequiredField;

        private bool isLightingFactsLabelRequiredFieldSpecified;

        private string lightingFactsLabelField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private CurrencyUnit estimatedEnergyCostPerYearField;

        private TemperatureUnit colorTemperatureField;

        private string numberOfLightBulbsField;

        private string lightBulbBaseTypeField;

        private LengthUnit lightBulbDiameterField;

        private bool isLightBulbIncludedField;

        private bool isLightBulbIncludedFieldSpecified;

        private AngleUnit beamAngleField;

        private AngleUnit beamSpreadField;

        private LengthUnit compatibleConduitSizesField;

        private bool isDarkSkyCompliantField;

        private bool isDarkSkyCompliantFieldSpecified;

        private decimal electricalBallastFactorField;

        private bool electricalBallastFactorFieldSpecified;

        private bool isRatedForOutdoorUseField;

        private bool isRatedForOutdoorUseFieldSpecified;

        private decimal maximumEnergySurgeRatingField;

        private bool maximumEnergySurgeRatingFieldSpecified;

        private AreaUnit maximumRangeField;

        private TimeUnit responseTimeField;

        private string numberOfGangsField;

        private string numberOfPolesField;

        private LengthUnit americanWireGaugeField;

        private BrightnessUnit brightnessField;

        private string lifespanField;

        private bool hasCeeCertificationField;

        private bool hasCeeCertificationFieldSpecified;

        private ElectricalCeeTier ceeTierField;

        private bool ceeTierFieldSpecified;

        private ElectricalMeasurementUnit ampsField;

        private PowerUnit decibelRatingField;

        private PowerUnit horsepowerField;

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
        public CurrencyUnit estimatedEnergyCostPerYear
        {
            get
            {
                return this.estimatedEnergyCostPerYearField;
            }
            set
            {
                this.estimatedEnergyCostPerYearField = value;
            }
        }

        /// <remarks/>
        public TemperatureUnit colorTemperature
        {
            get
            {
                return this.colorTemperatureField;
            }
            set
            {
                this.colorTemperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfLightBulbs
        {
            get
            {
                return this.numberOfLightBulbsField;
            }
            set
            {
                this.numberOfLightBulbsField = value;
            }
        }

        /// <remarks/>
        public string lightBulbBaseType
        {
            get
            {
                return this.lightBulbBaseTypeField;
            }
            set
            {
                this.lightBulbBaseTypeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit lightBulbDiameter
        {
            get
            {
                return this.lightBulbDiameterField;
            }
            set
            {
                this.lightBulbDiameterField = value;
            }
        }

        /// <remarks/>
        public bool isLightBulbIncluded
        {
            get
            {
                return this.isLightBulbIncludedField;
            }
            set
            {
                this.isLightBulbIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightBulbIncludedSpecified
        {
            get
            {
                return this.isLightBulbIncludedFieldSpecified;
            }
            set
            {
                this.isLightBulbIncludedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AngleUnit beamAngle
        {
            get
            {
                return this.beamAngleField;
            }
            set
            {
                this.beamAngleField = value;
            }
        }

        /// <remarks/>
        public AngleUnit beamSpread
        {
            get
            {
                return this.beamSpreadField;
            }
            set
            {
                this.beamSpreadField = value;
            }
        }

        /// <remarks/>
        public LengthUnit compatibleConduitSizes
        {
            get
            {
                return this.compatibleConduitSizesField;
            }
            set
            {
                this.compatibleConduitSizesField = value;
            }
        }

        /// <remarks/>
        public bool isDarkSkyCompliant
        {
            get
            {
                return this.isDarkSkyCompliantField;
            }
            set
            {
                this.isDarkSkyCompliantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDarkSkyCompliantSpecified
        {
            get
            {
                return this.isDarkSkyCompliantFieldSpecified;
            }
            set
            {
                this.isDarkSkyCompliantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal electricalBallastFactor
        {
            get
            {
                return this.electricalBallastFactorField;
            }
            set
            {
                this.electricalBallastFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool electricalBallastFactorSpecified
        {
            get
            {
                return this.electricalBallastFactorFieldSpecified;
            }
            set
            {
                this.electricalBallastFactorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isRatedForOutdoorUse
        {
            get
            {
                return this.isRatedForOutdoorUseField;
            }
            set
            {
                this.isRatedForOutdoorUseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRatedForOutdoorUseSpecified
        {
            get
            {
                return this.isRatedForOutdoorUseFieldSpecified;
            }
            set
            {
                this.isRatedForOutdoorUseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal maximumEnergySurgeRating
        {
            get
            {
                return this.maximumEnergySurgeRatingField;
            }
            set
            {
                this.maximumEnergySurgeRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumEnergySurgeRatingSpecified
        {
            get
            {
                return this.maximumEnergySurgeRatingFieldSpecified;
            }
            set
            {
                this.maximumEnergySurgeRatingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AreaUnit maximumRange
        {
            get
            {
                return this.maximumRangeField;
            }
            set
            {
                this.maximumRangeField = value;
            }
        }

        /// <remarks/>
        public TimeUnit responseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfGangs
        {
            get
            {
                return this.numberOfGangsField;
            }
            set
            {
                this.numberOfGangsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPoles
        {
            get
            {
                return this.numberOfPolesField;
            }
            set
            {
                this.numberOfPolesField = value;
            }
        }

        /// <remarks/>
        public LengthUnit americanWireGauge
        {
            get
            {
                return this.americanWireGaugeField;
            }
            set
            {
                this.americanWireGaugeField = value;
            }
        }

        /// <remarks/>
        public BrightnessUnit brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string lifespan
        {
            get
            {
                return this.lifespanField;
            }
            set
            {
                this.lifespanField = value;
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
        public ElectricalCeeTier ceeTier
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
        public ElectricalMeasurementUnit amps
        {
            get
            {
                return this.ampsField;
            }
            set
            {
                this.ampsField = value;
            }
        }

        /// <remarks/>
        public PowerUnit decibelRating
        {
            get
            {
                return this.decibelRatingField;
            }
            set
            {
                this.decibelRatingField = value;
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