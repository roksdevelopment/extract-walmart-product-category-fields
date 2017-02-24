namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MedicineAndSupplements
    {

        private bool isDrugFactsLabelRequiredField;

        private bool isDrugFactsLabelRequiredFieldSpecified;

        private string drugFactsLabelField;

        private bool isSupplementFactsLabelRequiredField;

        private bool isSupplementFactsLabelRequiredFieldSpecified;

        private string supplementFactsLabelField;

        private string servingSizeField;

        private decimal servingsPerContainerField;

        private bool servingsPerContainerFieldSpecified;

        private activeIngredient[] activeIngredientsField;

        private string[] inactiveIngredientsField;

        private string[] healthConcernsField;

        private string formField;

        private string[] organicCertificationsField;

        private string instructionsField;

        private string dosageField;

        private string[] stopUseIndicationsField;

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
        public bool isSupplementFactsLabelRequired
        {
            get
            {
                return this.isSupplementFactsLabelRequiredField;
            }
            set
            {
                this.isSupplementFactsLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSupplementFactsLabelRequiredSpecified
        {
            get
            {
                return this.isSupplementFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isSupplementFactsLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string supplementFactsLabel
        {
            get
            {
                return this.supplementFactsLabelField;
            }
            set
            {
                this.supplementFactsLabelField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("healthConcern", IsNullable = false)]
        public string[] healthConcerns
        {
            get
            {
                return this.healthConcernsField;
            }
            set
            {
                this.healthConcernsField = value;
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
    }
}