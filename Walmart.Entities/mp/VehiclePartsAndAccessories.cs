namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class VehiclePartsAndAccessories
    {

        private fabricContentValue[] fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private string finishField;

        private LengthUnit chainLengthField;

        private string[] fabricCareInstructionsField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private string[] connectionsField;

        private string[] characterField;

        private string powerTypeField;

        private LengthUnit tireDiameterField;

        private string[] fillMaterialField;

        private VolumeUnit fluidOuncesField;

        private TemperatureUnit maximumTemperatureField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private bool isLightBulbIncludedField;

        private bool isLightBulbIncludedFieldSpecified;

        private string vehicleMakeField;

        private AngleUnit beamAngleField;

        private AngleUnit beamSpreadField;

        private string vehicleModelField;

        private string vehicleTypeField;

        private string vehicleYearField;

        private string automotiveWindowShadeFitField;

        private WeightUnit breakingStrengthField;

        private string candlePowerField;

        private ResolutionUnit displayResolutionField;

        private string formField;

        private string coldCrankAmpField;

        private string compatibleCarsField;

        private LengthUnit dropDistanceField;

        private string shapeField;

        private string fastenerHeadTypeField;

        private bool isLockableField;

        private bool isLockableFieldSpecified;

        private TimeUnit filterLifeField;

        private string flashPointField;

        private bool fullyIncinerableField;

        private bool fullyIncinerableFieldSpecified;

        private string hitchClassField;

        private bool inDashSystemField;

        private bool inDashSystemFieldSpecified;

        private string[] interfaceTypeField;

        private string displayTechnologyField;

        private decimal maximumMotorSpeedField;

        private bool maximumMotorSpeedFieldSpecified;

        private string numberOfOutletsField;

        private string numberOfPhasesField;

        private LengthUnit receiverCompatibilityField;

        private TimeUnit reserveCapacityField;

        private bool saeDotCompliantField;

        private bool saeDotCompliantFieldSpecified;

        private LengthUnit shackleClearanceField;

        private LengthUnit shackleDiameterField;

        private LengthUnit shackleLengthField;

        private LengthUnit shankLengthField;

        private WeightUnit shearStrengthField;

        private bool hasShortCircuitProtectionField;

        private bool hasShortCircuitProtectionFieldSpecified;

        private LengthUnit thicknessField;

        private LengthUnit threadSizeField;

        private string towingMirrorSideField;

        private string lightBulbTypeField;

        private LengthUnit cableLengthField;

        private string[] compatibleBrandsField;

        private string[] compatibleDevicesField;

        private string[] wirelessTechnologiesField;

        private ElectricalMeasurementUnit ampsField;

        private WeightUnit maximumLoadWeightField;

        private PowerUnit horsepowerField;

        private PressureUnit loadCapacityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public fabricContentValue[] fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        /// <remarks/>
        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
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
        public LengthUnit chainLength
        {
            get
            {
                return this.chainLengthField;
            }
            set
            {
                this.chainLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public string[] fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
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
        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public string[] connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
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
        public LengthUnit tireDiameter
        {
            get
            {
                return this.tireDiameterField;
            }
            set
            {
                this.tireDiameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public string[] fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        /// <remarks/>
        public VolumeUnit fluidOunces
        {
            get
            {
                return this.fluidOuncesField;
            }
            set
            {
                this.fluidOuncesField = value;
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
        public string vehicleMake
        {
            get
            {
                return this.vehicleMakeField;
            }
            set
            {
                this.vehicleMakeField = value;
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
        public string vehicleModel
        {
            get
            {
                return this.vehicleModelField;
            }
            set
            {
                this.vehicleModelField = value;
            }
        }

        /// <remarks/>
        public string vehicleType
        {
            get
            {
                return this.vehicleTypeField;
            }
            set
            {
                this.vehicleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string vehicleYear
        {
            get
            {
                return this.vehicleYearField;
            }
            set
            {
                this.vehicleYearField = value;
            }
        }

        /// <remarks/>
        public string automotiveWindowShadeFit
        {
            get
            {
                return this.automotiveWindowShadeFitField;
            }
            set
            {
                this.automotiveWindowShadeFitField = value;
            }
        }

        /// <remarks/>
        public WeightUnit breakingStrength
        {
            get
            {
                return this.breakingStrengthField;
            }
            set
            {
                this.breakingStrengthField = value;
            }
        }

        /// <remarks/>
        public string candlePower
        {
            get
            {
                return this.candlePowerField;
            }
            set
            {
                this.candlePowerField = value;
            }
        }

        /// <remarks/>
        public ResolutionUnit displayResolution
        {
            get
            {
                return this.displayResolutionField;
            }
            set
            {
                this.displayResolutionField = value;
            }
        }

        /// <remarks/>
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string coldCrankAmp
        {
            get
            {
                return this.coldCrankAmpField;
            }
            set
            {
                this.coldCrankAmpField = value;
            }
        }

        /// <remarks/>
        public string compatibleCars
        {
            get
            {
                return this.compatibleCarsField;
            }
            set
            {
                this.compatibleCarsField = value;
            }
        }

        /// <remarks/>
        public LengthUnit dropDistance
        {
            get
            {
                return this.dropDistanceField;
            }
            set
            {
                this.dropDistanceField = value;
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

        /// <remarks/>
        public string fastenerHeadType
        {
            get
            {
                return this.fastenerHeadTypeField;
            }
            set
            {
                this.fastenerHeadTypeField = value;
            }
        }

        /// <remarks/>
        public bool isLockable
        {
            get
            {
                return this.isLockableField;
            }
            set
            {
                this.isLockableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLockableSpecified
        {
            get
            {
                return this.isLockableFieldSpecified;
            }
            set
            {
                this.isLockableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeUnit filterLife
        {
            get
            {
                return this.filterLifeField;
            }
            set
            {
                this.filterLifeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string flashPoint
        {
            get
            {
                return this.flashPointField;
            }
            set
            {
                this.flashPointField = value;
            }
        }

        /// <remarks/>
        public bool fullyIncinerable
        {
            get
            {
                return this.fullyIncinerableField;
            }
            set
            {
                this.fullyIncinerableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fullyIncinerableSpecified
        {
            get
            {
                return this.fullyIncinerableFieldSpecified;
            }
            set
            {
                this.fullyIncinerableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string hitchClass
        {
            get
            {
                return this.hitchClassField;
            }
            set
            {
                this.hitchClassField = value;
            }
        }

        /// <remarks/>
        public bool inDashSystem
        {
            get
            {
                return this.inDashSystemField;
            }
            set
            {
                this.inDashSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inDashSystemSpecified
        {
            get
            {
                return this.inDashSystemFieldSpecified;
            }
            set
            {
                this.inDashSystemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("interfaceTypeValue", IsNullable = false)]
        public string[] interfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
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
        public decimal maximumMotorSpeed
        {
            get
            {
                return this.maximumMotorSpeedField;
            }
            set
            {
                this.maximumMotorSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumMotorSpeedSpecified
        {
            get
            {
                return this.maximumMotorSpeedFieldSpecified;
            }
            set
            {
                this.maximumMotorSpeedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfOutlets
        {
            get
            {
                return this.numberOfOutletsField;
            }
            set
            {
                this.numberOfOutletsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPhases
        {
            get
            {
                return this.numberOfPhasesField;
            }
            set
            {
                this.numberOfPhasesField = value;
            }
        }

        /// <remarks/>
        public LengthUnit receiverCompatibility
        {
            get
            {
                return this.receiverCompatibilityField;
            }
            set
            {
                this.receiverCompatibilityField = value;
            }
        }

        /// <remarks/>
        public TimeUnit reserveCapacity
        {
            get
            {
                return this.reserveCapacityField;
            }
            set
            {
                this.reserveCapacityField = value;
            }
        }

        /// <remarks/>
        public bool saeDotCompliant
        {
            get
            {
                return this.saeDotCompliantField;
            }
            set
            {
                this.saeDotCompliantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saeDotCompliantSpecified
        {
            get
            {
                return this.saeDotCompliantFieldSpecified;
            }
            set
            {
                this.saeDotCompliantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LengthUnit shackleClearance
        {
            get
            {
                return this.shackleClearanceField;
            }
            set
            {
                this.shackleClearanceField = value;
            }
        }

        /// <remarks/>
        public LengthUnit shackleDiameter
        {
            get
            {
                return this.shackleDiameterField;
            }
            set
            {
                this.shackleDiameterField = value;
            }
        }

        /// <remarks/>
        public LengthUnit shackleLength
        {
            get
            {
                return this.shackleLengthField;
            }
            set
            {
                this.shackleLengthField = value;
            }
        }

        /// <remarks/>
        public LengthUnit shankLength
        {
            get
            {
                return this.shankLengthField;
            }
            set
            {
                this.shankLengthField = value;
            }
        }

        /// <remarks/>
        public WeightUnit shearStrength
        {
            get
            {
                return this.shearStrengthField;
            }
            set
            {
                this.shearStrengthField = value;
            }
        }

        /// <remarks/>
        public bool hasShortCircuitProtection
        {
            get
            {
                return this.hasShortCircuitProtectionField;
            }
            set
            {
                this.hasShortCircuitProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasShortCircuitProtectionSpecified
        {
            get
            {
                return this.hasShortCircuitProtectionFieldSpecified;
            }
            set
            {
                this.hasShortCircuitProtectionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LengthUnit thickness
        {
            get
            {
                return this.thicknessField;
            }
            set
            {
                this.thicknessField = value;
            }
        }

        /// <remarks/>
        public LengthUnit threadSize
        {
            get
            {
                return this.threadSizeField;
            }
            set
            {
                this.threadSizeField = value;
            }
        }

        /// <remarks/>
        public string towingMirrorSide
        {
            get
            {
                return this.towingMirrorSideField;
            }
            set
            {
                this.towingMirrorSideField = value;
            }
        }

        /// <remarks/>
        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit cableLength
        {
            get
            {
                return this.cableLengthField;
            }
            set
            {
                this.cableLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public string[] compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public string[] compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
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
        public WeightUnit maximumLoadWeight
        {
            get
            {
                return this.maximumLoadWeightField;
            }
            set
            {
                this.maximumLoadWeightField = value;
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

        /// <remarks/>
        public PressureUnit loadCapacity
        {
            get
            {
                return this.loadCapacityField;
            }
            set
            {
                this.loadCapacityField = value;
            }
        }
    }
}