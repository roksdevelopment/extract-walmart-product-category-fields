namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Toy
    {

        private string animalBreedField;

        private swatchImage[] swatchImagesField;

        private ToyAgeRange ageRangeField;

        private WeightUnit minimumWeightField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string finishField;

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private string[] fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string[] themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private ToyGender genderField;

        private bool genderFieldSpecified;

        private string[] colorField;

        private string[] ageGroupField;

        private string[] awardsWonField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private string animalTypeField;

        private string[] materialField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private string[] characterField;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private string[] occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private bool isTravelSizeField;

        private bool isTravelSizeFieldSpecified;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private string seatingCapacityField;

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private TimeUnit maximumRecommendedAgeField;

        private string assemblyInstructionsField;

        private TimeUnit minimumRecommendedAgeField;

        private string[] sportField;

        private string skillLevelField;

        private WeightUnit maximumWeightField;

        private string[] targetAudienceField;

        private SpeedUnit maximumSpeedField;

        private string[] educationalFocusField;

        private string capacityField;

        private string skinToneField;

        private ElectricalMeasurementUnit voltsField;

        private string vehicleTypeField;

        private string shapeField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private object itemField;

        /// <remarks/>
        public string animalBreed
        {
            get
            {
                return this.animalBreedField;
            }
            set
            {
                this.animalBreedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public swatchImage[] swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        /// <remarks/>
        public ToyAgeRange ageRange
        {
            get
            {
                return this.ageRangeField;
            }
            set
            {
                this.ageRangeField = value;
            }
        }

        /// <remarks/>
        public WeightUnit minimumWeight
        {
            get
            {
                return this.minimumWeightField;
            }
            set
            {
                this.minimumWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public string[] variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        /// <remarks/>
        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        /// <remarks/>
        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

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
        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
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
        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
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
        public string brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }

        /// <remarks/>
        public string manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public string[] theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        /// <remarks/>
        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        /// <remarks/>
        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        /// <remarks/>
        public ToyGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public string[] color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public string[] ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("awardsWonValue", IsNullable = false)]
        public string[] awardsWon
        {
            get
            {
                return this.awardsWonField;
            }
            set
            {
                this.awardsWonField = value;
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
        public string animalType
        {
            get
            {
                return this.animalTypeField;
            }
            set
            {
                this.animalTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public string[] material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPieces
        {
            get
            {
                return this.numberOfPiecesField;
            }
            set
            {
                this.numberOfPiecesField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public string[] occasion
        {
            get
            {
                return this.occasionField;
            }
            set
            {
                this.occasionField = value;
            }
        }

        /// <remarks/>
        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isTravelSize
        {
            get
            {
                return this.isTravelSizeField;
            }
            set
            {
                this.isTravelSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTravelSizeSpecified
        {
            get
            {
                return this.isTravelSizeFieldSpecified;
            }
            set
            {
                this.isTravelSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public recycledMaterialContentValue[] recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
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
        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
        {
            get
            {
                return this.isAssemblyRequiredFieldSpecified;
            }
            set
            {
                this.isAssemblyRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeUnit maximumRecommendedAge
        {
            get
            {
                return this.maximumRecommendedAgeField;
            }
            set
            {
                this.maximumRecommendedAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string assemblyInstructions
        {
            get
            {
                return this.assemblyInstructionsField;
            }
            set
            {
                this.assemblyInstructionsField = value;
            }
        }

        /// <remarks/>
        public TimeUnit minimumRecommendedAge
        {
            get
            {
                return this.minimumRecommendedAgeField;
            }
            set
            {
                this.minimumRecommendedAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public string[] sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        /// <remarks/>
        public string skillLevel
        {
            get
            {
                return this.skillLevelField;
            }
            set
            {
                this.skillLevelField = value;
            }
        }

        /// <remarks/>
        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public string[] targetAudience
        {
            get
            {
                return this.targetAudienceField;
            }
            set
            {
                this.targetAudienceField = value;
            }
        }

        /// <remarks/>
        public SpeedUnit maximumSpeed
        {
            get
            {
                return this.maximumSpeedField;
            }
            set
            {
                this.maximumSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("educationalFocu", IsNullable = false)]
        public string[] educationalFocus
        {
            get
            {
                return this.educationalFocusField;
            }
            set
            {
                this.educationalFocusField = value;
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
        public string skinTone
        {
            get
            {
                return this.skinToneField;
            }
            set
            {
                this.skinToneField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Games", typeof(Games))]
        [System.Xml.Serialization.XmlElementAttribute("Puzzles", typeof(Puzzles))]
        [System.Xml.Serialization.XmlElementAttribute("Toys", typeof(Toys))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}