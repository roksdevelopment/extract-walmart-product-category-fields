namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class AnimalHealthAndGrooming
    {

        private string conditionField;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private string powerTypeField;

        private string animalHealthConcernField;

        private string[] hairLengthField;

        private string scentField;

        private bool isDrugFactsLabelRequiredField;

        private bool isDrugFactsLabelRequiredFieldSpecified;

        private string drugFactsLabelField;

        private activeIngredient[] activeIngredientsField;

        private string[] inactiveIngredientsField;

        private string formField;

        private string instructionsField;

        private string dosageField;

        private string[] stopUseIndicationsField;

        private string petSizeField;

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
        public string animalHealthConcern
        {
            get
            {
                return this.animalHealthConcernField;
            }
            set
            {
                this.animalHealthConcernField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("hairLengthValue", IsNullable = false)]
        public string[] hairLength
        {
            get
            {
                return this.hairLengthField;
            }
            set
            {
                this.hairLengthField = value;
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
        public bool isDrugFactsLabelRequired
        {
            get
            {
                return this.isDrugFactsLabelRequiredField;
            }
            set
            {
                this.isDrugFactsLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDrugFactsLabelRequiredSpecified
        {
            get
            {
                return this.isDrugFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isDrugFactsLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string drugFactsLabel
        {
            get
            {
                return this.drugFactsLabelField;
            }
            set
            {
                this.drugFactsLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public activeIngredient[] activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public string[] inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
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
        public string dosage
        {
            get
            {
                return this.dosageField;
            }
            set
            {
                this.dosageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("stopUseIndication", IsNullable = false)]
        public string[] stopUseIndications
        {
            get
            {
                return this.stopUseIndicationsField;
            }
            set
            {
                this.stopUseIndicationsField = value;
            }
        }

        /// <remarks/>
        public string petSize
        {
            get
            {
                return this.petSizeField;
            }
            set
            {
                this.petSizeField = value;
            }
        }
    }
}