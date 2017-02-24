namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class FoodAndBeverage
    {

        private bool isNutritionFactsLabelRequiredField;

        private bool isNutritionFactsLabelRequiredFieldSpecified;

        private string nutritionFactsLabelField;

        private string foodFormField;

        private bool isImitationField;

        private bool isImitationFieldSpecified;

        private string[] foodAllergenStatementsField;

        private bool usdaInspectedField;

        private bool usdaInspectedFieldSpecified;

        private string vintageField;

        private TimeUnit timeAgedField;

        private string[] variantAttributeNamesField;

        private bool isGmoFreeField;

        private bool isGmoFreeFieldSpecified;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isBpaFreeField;

        private bool isBpaFreeFieldSpecified;

        private bool isPotentiallyHazardousFoodField;

        private bool isPotentiallyHazardousFoodFieldSpecified;

        private bool isReadyToEatField;

        private bool isReadyToEatFieldSpecified;

        private string caffeineDesignationField;

        private string brandField;

        private string manufacturerField;

        private string spiceLevelField;

        private string flavorField;

        private string beefCutField;

        private string poultryCutField;

        private string[] colorField;

        private bool isMadeInHomeKitchenField;

        private bool isMadeInHomeKitchenFieldSpecified;

        private string[] nutrientContentClaimsField;

        private string safeHandlingInstructionsField;

        private string[] characterField;

        private string[] occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private decimal fatCaloriesPerGramField;

        private bool fatCaloriesPerGramFieldSpecified;

        private string[] recommendedUsesField;

        private decimal carbohydrateCaloriesPerGramField;

        private bool carbohydrateCaloriesPerGramFieldSpecified;

        private WeightUnit totalProteinField;

        private PercentageUnit totalProteinPercentageDailyValueField;

        private decimal proteinCaloriesPerGramField;

        private bool proteinCaloriesPerGramFieldSpecified;

        private bool isFairTradeField;

        private bool isFairTradeFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private string ingredientsField;

        private System.DateTime releaseDateField;

        private bool releaseDateFieldSpecified;

        private string servingSizeField;

        private decimal servingsPerContainerField;

        private bool servingsPerContainerFieldSpecified;

        private string[] organicCertificationsField;

        private string instructionsField;

        private decimal caloriesField;

        private bool caloriesFieldSpecified;

        private WeightUnit caloriesFromFatField;

        private WeightUnit totalFatField;

        private PercentageUnit totalFatPercentageDailyValueField;

        private WeightUnit totalCarbohydrateField;

        private PercentageUnit totalCarbohydratePercentageDailyValueField;

        private nutrient[] nutrientsField;

        private AlcoholicBeverages itemField;

        /// <remarks/>
        public bool isNutritionFactsLabelRequired
        {
            get
            {
                return this.isNutritionFactsLabelRequiredField;
            }
            set
            {
                this.isNutritionFactsLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNutritionFactsLabelRequiredSpecified
        {
            get
            {
                return this.isNutritionFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isNutritionFactsLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string nutritionFactsLabel
        {
            get
            {
                return this.nutritionFactsLabelField;
            }
            set
            {
                this.nutritionFactsLabelField = value;
            }
        }

        /// <remarks/>
        public string foodForm
        {
            get
            {
                return this.foodFormField;
            }
            set
            {
                this.foodFormField = value;
            }
        }

        /// <remarks/>
        public bool isImitation
        {
            get
            {
                return this.isImitationField;
            }
            set
            {
                this.isImitationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isImitationSpecified
        {
            get
            {
                return this.isImitationFieldSpecified;
            }
            set
            {
                this.isImitationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("foodAllergenStatement", IsNullable = false)]
        public string[] foodAllergenStatements
        {
            get
            {
                return this.foodAllergenStatementsField;
            }
            set
            {
                this.foodAllergenStatementsField = value;
            }
        }

        /// <remarks/>
        public bool usdaInspected
        {
            get
            {
                return this.usdaInspectedField;
            }
            set
            {
                this.usdaInspectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usdaInspectedSpecified
        {
            get
            {
                return this.usdaInspectedFieldSpecified;
            }
            set
            {
                this.usdaInspectedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string vintage
        {
            get
            {
                return this.vintageField;
            }
            set
            {
                this.vintageField = value;
            }
        }

        /// <remarks/>
        public TimeUnit timeAged
        {
            get
            {
                return this.timeAgedField;
            }
            set
            {
                this.timeAgedField = value;
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
        public bool isGmoFree
        {
            get
            {
                return this.isGmoFreeField;
            }
            set
            {
                this.isGmoFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isGmoFreeSpecified
        {
            get
            {
                return this.isGmoFreeFieldSpecified;
            }
            set
            {
                this.isGmoFreeFieldSpecified = value;
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
        public bool isBpaFree
        {
            get
            {
                return this.isBpaFreeField;
            }
            set
            {
                this.isBpaFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBpaFreeSpecified
        {
            get
            {
                return this.isBpaFreeFieldSpecified;
            }
            set
            {
                this.isBpaFreeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isPotentiallyHazardousFood
        {
            get
            {
                return this.isPotentiallyHazardousFoodField;
            }
            set
            {
                this.isPotentiallyHazardousFoodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPotentiallyHazardousFoodSpecified
        {
            get
            {
                return this.isPotentiallyHazardousFoodFieldSpecified;
            }
            set
            {
                this.isPotentiallyHazardousFoodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isReadyToEat
        {
            get
            {
                return this.isReadyToEatField;
            }
            set
            {
                this.isReadyToEatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReadyToEatSpecified
        {
            get
            {
                return this.isReadyToEatFieldSpecified;
            }
            set
            {
                this.isReadyToEatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string caffeineDesignation
        {
            get
            {
                return this.caffeineDesignationField;
            }
            set
            {
                this.caffeineDesignationField = value;
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
        public string spiceLevel
        {
            get
            {
                return this.spiceLevelField;
            }
            set
            {
                this.spiceLevelField = value;
            }
        }

        /// <remarks/>
        public string flavor
        {
            get
            {
                return this.flavorField;
            }
            set
            {
                this.flavorField = value;
            }
        }

        /// <remarks/>
        public string beefCut
        {
            get
            {
                return this.beefCutField;
            }
            set
            {
                this.beefCutField = value;
            }
        }

        /// <remarks/>
        public string poultryCut
        {
            get
            {
                return this.poultryCutField;
            }
            set
            {
                this.poultryCutField = value;
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
        public bool isMadeInHomeKitchen
        {
            get
            {
                return this.isMadeInHomeKitchenField;
            }
            set
            {
                this.isMadeInHomeKitchenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeInHomeKitchenSpecified
        {
            get
            {
                return this.isMadeInHomeKitchenFieldSpecified;
            }
            set
            {
                this.isMadeInHomeKitchenFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("nutrientContentClaim", IsNullable = false)]
        public string[] nutrientContentClaims
        {
            get
            {
                return this.nutrientContentClaimsField;
            }
            set
            {
                this.nutrientContentClaimsField = value;
            }
        }

        /// <remarks/>
        public string safeHandlingInstructions
        {
            get
            {
                return this.safeHandlingInstructionsField;
            }
            set
            {
                this.safeHandlingInstructionsField = value;
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
        public decimal fatCaloriesPerGram
        {
            get
            {
                return this.fatCaloriesPerGramField;
            }
            set
            {
                this.fatCaloriesPerGramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fatCaloriesPerGramSpecified
        {
            get
            {
                return this.fatCaloriesPerGramFieldSpecified;
            }
            set
            {
                this.fatCaloriesPerGramFieldSpecified = value;
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
        public decimal carbohydrateCaloriesPerGram
        {
            get
            {
                return this.carbohydrateCaloriesPerGramField;
            }
            set
            {
                this.carbohydrateCaloriesPerGramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool carbohydrateCaloriesPerGramSpecified
        {
            get
            {
                return this.carbohydrateCaloriesPerGramFieldSpecified;
            }
            set
            {
                this.carbohydrateCaloriesPerGramFieldSpecified = value;
            }
        }

        /// <remarks/>
        public WeightUnit totalProtein
        {
            get
            {
                return this.totalProteinField;
            }
            set
            {
                this.totalProteinField = value;
            }
        }

        /// <remarks/>
        public PercentageUnit totalProteinPercentageDailyValue
        {
            get
            {
                return this.totalProteinPercentageDailyValueField;
            }
            set
            {
                this.totalProteinPercentageDailyValueField = value;
            }
        }

        /// <remarks/>
        public decimal proteinCaloriesPerGram
        {
            get
            {
                return this.proteinCaloriesPerGramField;
            }
            set
            {
                this.proteinCaloriesPerGramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool proteinCaloriesPerGramSpecified
        {
            get
            {
                return this.proteinCaloriesPerGramFieldSpecified;
            }
            set
            {
                this.proteinCaloriesPerGramFieldSpecified = value;
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
        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ingredients
        {
            get
            {
                return this.ingredientsField;
            }
            set
            {
                this.ingredientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime releaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified
        {
            get
            {
                return this.releaseDateFieldSpecified;
            }
            set
            {
                this.releaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string servingSize
        {
            get
            {
                return this.servingSizeField;
            }
            set
            {
                this.servingSizeField = value;
            }
        }

        /// <remarks/>
        public decimal servingsPerContainer
        {
            get
            {
                return this.servingsPerContainerField;
            }
            set
            {
                this.servingsPerContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool servingsPerContainerSpecified
        {
            get
            {
                return this.servingsPerContainerFieldSpecified;
            }
            set
            {
                this.servingsPerContainerFieldSpecified = value;
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
        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        /// <remarks/>
        public decimal calories
        {
            get
            {
                return this.caloriesField;
            }
            set
            {
                this.caloriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caloriesSpecified
        {
            get
            {
                return this.caloriesFieldSpecified;
            }
            set
            {
                this.caloriesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public WeightUnit caloriesFromFat
        {
            get
            {
                return this.caloriesFromFatField;
            }
            set
            {
                this.caloriesFromFatField = value;
            }
        }

        /// <remarks/>
        public WeightUnit totalFat
        {
            get
            {
                return this.totalFatField;
            }
            set
            {
                this.totalFatField = value;
            }
        }

        /// <remarks/>
        public PercentageUnit totalFatPercentageDailyValue
        {
            get
            {
                return this.totalFatPercentageDailyValueField;
            }
            set
            {
                this.totalFatPercentageDailyValueField = value;
            }
        }

        /// <remarks/>
        public WeightUnit totalCarbohydrate
        {
            get
            {
                return this.totalCarbohydrateField;
            }
            set
            {
                this.totalCarbohydrateField = value;
            }
        }

        /// <remarks/>
        public PercentageUnit totalCarbohydratePercentageDailyValue
        {
            get
            {
                return this.totalCarbohydratePercentageDailyValueField;
            }
            set
            {
                this.totalCarbohydratePercentageDailyValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public nutrient[] nutrients
        {
            get
            {
                return this.nutrientsField;
            }
            set
            {
                this.nutrientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlcoholicBeverages")]
        public AlcoholicBeverages Item
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