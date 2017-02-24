namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BabyFood
    {

        private string flavorField;

        private string[] nutrientContentClaimsField;

        private string servingSizeField;

        private decimal servingsPerContainerField;

        private bool servingsPerContainerFieldSpecified;

        private bool isBabyFormulaLabelRequiredField;

        private bool isBabyFormulaLabelRequiredFieldSpecified;

        private string babyFormulaLabelField;

        private bool isChildrenUnder2LabelRequiredField;

        private bool isChildrenUnder2LabelRequiredFieldSpecified;

        private string childrenUnder2LabelField;

        private bool isChildrenUnder4LabelRequiredField;

        private bool isChildrenUnder4LabelRequiredFieldSpecified;

        private string childrenUnder4LabelField;

        private VolumeUnit fluidOuncesSupplying100CaloriesField;

        private decimal caloriesField;

        private bool caloriesFieldSpecified;

        private WeightUnit caloriesFromFatField;

        private WeightUnit totalFatField;

        private PercentageUnit totalFatPercentageDailyValueField;

        private WeightUnit totalCarbohydrateField;

        private PercentageUnit totalCarbohydratePercentageDailyValueField;

        private nutrient[] nutrientsField;

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
        public bool isBabyFormulaLabelRequired
        {
            get
            {
                return this.isBabyFormulaLabelRequiredField;
            }
            set
            {
                this.isBabyFormulaLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBabyFormulaLabelRequiredSpecified
        {
            get
            {
                return this.isBabyFormulaLabelRequiredFieldSpecified;
            }
            set
            {
                this.isBabyFormulaLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string babyFormulaLabel
        {
            get
            {
                return this.babyFormulaLabelField;
            }
            set
            {
                this.babyFormulaLabelField = value;
            }
        }

        /// <remarks/>
        public bool isChildrenUnder2LabelRequired
        {
            get
            {
                return this.isChildrenUnder2LabelRequiredField;
            }
            set
            {
                this.isChildrenUnder2LabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isChildrenUnder2LabelRequiredSpecified
        {
            get
            {
                return this.isChildrenUnder2LabelRequiredFieldSpecified;
            }
            set
            {
                this.isChildrenUnder2LabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string childrenUnder2Label
        {
            get
            {
                return this.childrenUnder2LabelField;
            }
            set
            {
                this.childrenUnder2LabelField = value;
            }
        }

        /// <remarks/>
        public bool isChildrenUnder4LabelRequired
        {
            get
            {
                return this.isChildrenUnder4LabelRequiredField;
            }
            set
            {
                this.isChildrenUnder4LabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isChildrenUnder4LabelRequiredSpecified
        {
            get
            {
                return this.isChildrenUnder4LabelRequiredFieldSpecified;
            }
            set
            {
                this.isChildrenUnder4LabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string childrenUnder4Label
        {
            get
            {
                return this.childrenUnder4LabelField;
            }
            set
            {
                this.childrenUnder4LabelField = value;
            }
        }

        /// <remarks/>
        public VolumeUnit fluidOuncesSupplying100Calories
        {
            get
            {
                return this.fluidOuncesSupplying100CaloriesField;
            }
            set
            {
                this.fluidOuncesSupplying100CaloriesField = value;
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
    }
}