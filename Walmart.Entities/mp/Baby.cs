namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Baby
    {

        private swatchImage[] swatchImagesField;

        private BabyAgeRange ageRangeField;

        private bool ageRangeFieldSpecified;

        private WeightUnit minimumWeightField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private string[] fabricCareInstructionsField;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private BabyGender genderField;

        private bool genderFieldSpecified;

        private string[] colorField;

        private string[] ageGroupField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private string[] patternField;

        private string[] materialField;

        private string numberOfPiecesField;

        private string[] characterField;

        private string[] occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private string[] recommendedUsesField;

        private string numberOfChannelsField;

        private bool isFairTradeField;

        private bool isFairTradeFieldSpecified;

        private TimeUnit maximumRecommendedAgeField;

        private TimeUnit minimumRecommendedAgeField;

        private string[] sportField;

        private WeightUnit maximumWeightField;

        private string[] diaposableBabyDiaperTypeField;

        private string capacityField;

        private string scentField;

        private string[] organicCertificationsField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private object itemField;

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
        public BabyAgeRange ageRange
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageRangeSpecified
        {
            get
            {
                return this.ageRangeFieldSpecified;
            }
            set
            {
                this.ageRangeFieldSpecified = value;
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
        public BabyGender gender
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
        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
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
        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public string[] recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        /// <remarks/>
        public string numberOfChannels
        {
            get
            {
                return this.numberOfChannelsField;
            }
            set
            {
                this.numberOfChannelsField = value;
            }
        }

        /// <remarks/>
        public bool isFairTrade
        {
            get
            {
                return this.isFairTradeField;
            }
            set
            {
                this.isFairTradeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFairTradeSpecified
        {
            get
            {
                return this.isFairTradeFieldSpecified;
            }
            set
            {
                this.isFairTradeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("diaposableBabyDiaperTypeValue", IsNullable = false)]
        public string[] diaposableBabyDiaperType
        {
            get
            {
                return this.diaposableBabyDiaperTypeField;
            }
            set
            {
                this.diaposableBabyDiaperTypeField = value;
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
        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("organicCertification", IsNullable = false)]
        public string[] organicCertifications
        {
            get
            {
                return this.organicCertificationsField;
            }
            set
            {
                this.organicCertificationsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("BabyClothing", typeof(BabyClothing))]
        [System.Xml.Serialization.XmlElementAttribute("BabyFood", typeof(BabyFood))]
        [System.Xml.Serialization.XmlElementAttribute("BabyFootwear", typeof(BabyFootwear))]
        [System.Xml.Serialization.XmlElementAttribute("BabyFurniture", typeof(BabyFurniture))]
        [System.Xml.Serialization.XmlElementAttribute("BabyToys", typeof(BabyToys))]
        [System.Xml.Serialization.XmlElementAttribute("ChildCarSeats", typeof(ChildCarSeats))]
        [System.Xml.Serialization.XmlElementAttribute("Strollers", typeof(Strollers))]
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