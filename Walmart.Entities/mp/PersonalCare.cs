namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class PersonalCare
    {

        private string[] ingredientClaimField;

        private bool isLatexFreeField;

        private bool isLatexFreeFieldSpecified;

        private string absorbencyField;

        private TimeUnit resultTimeField;

        private string skinCareConcernField;

        private string skinTypeField;

        private string hairTypeField;

        private string skinToneField;

        private string spfValueField;

        private bool isAntiAgingField;

        private bool isAntiAgingFieldSpecified;

        private bool isHypoallergenicField;

        private bool isHypoallergenicFieldSpecified;

        private bool isOilFreeField;

        private bool isOilFreeFieldSpecified;

        private bool isParabenFreeField;

        private bool isParabenFreeFieldSpecified;

        private bool isNoncomodegenicField;

        private bool isNoncomodegenicFieldSpecified;

        private string scentField;

        private bool isUnscentedField;

        private bool isUnscentedFieldSpecified;

        private bool isVeganField;

        private bool isVeganFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private bool isTintedField;

        private bool isTintedFieldSpecified;

        private bool isSelfTanningField;

        private bool isSelfTanningFieldSpecified;

        private bool isDrugFactsLabelRequiredField;

        private bool isDrugFactsLabelRequiredFieldSpecified;

        private string drugFactsLabelField;

        private activeIngredient[] activeIngredientsField;

        private string[] inactiveIngredientsField;

        private string formField;

        private string[] organicCertificationsField;

        private string instructionsField;

        private string[] stopUseIndicationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ingredientClaimValue", IsNullable = false)]
        public string[] ingredientClaim
        {
            get
            {
                return this.ingredientClaimField;
            }
            set
            {
                this.ingredientClaimField = value;
            }
        }

        /// <remarks/>
        public bool isLatexFree
        {
            get
            {
                return this.isLatexFreeField;
            }
            set
            {
                this.isLatexFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLatexFreeSpecified
        {
            get
            {
                return this.isLatexFreeFieldSpecified;
            }
            set
            {
                this.isLatexFreeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string absorbency
        {
            get
            {
                return this.absorbencyField;
            }
            set
            {
                this.absorbencyField = value;
            }
        }

        /// <remarks/>
        public TimeUnit resultTime
        {
            get
            {
                return this.resultTimeField;
            }
            set
            {
                this.resultTimeField = value;
            }
        }

        /// <remarks/>
        public string skinCareConcern
        {
            get
            {
                return this.skinCareConcernField;
            }
            set
            {
                this.skinCareConcernField = value;
            }
        }

        /// <remarks/>
        public string skinType
        {
            get
            {
                return this.skinTypeField;
            }
            set
            {
                this.skinTypeField = value;
            }
        }

        /// <remarks/>
        public string hairType
        {
            get
            {
                return this.hairTypeField;
            }
            set
            {
                this.hairTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string spfValue
        {
            get
            {
                return this.spfValueField;
            }
            set
            {
                this.spfValueField = value;
            }
        }

        /// <remarks/>
        public bool isAntiAging
        {
            get
            {
                return this.isAntiAgingField;
            }
            set
            {
                this.isAntiAgingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiAgingSpecified
        {
            get
            {
                return this.isAntiAgingFieldSpecified;
            }
            set
            {
                this.isAntiAgingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isHypoallergenic
        {
            get
            {
                return this.isHypoallergenicField;
            }
            set
            {
                this.isHypoallergenicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isHypoallergenicSpecified
        {
            get
            {
                return this.isHypoallergenicFieldSpecified;
            }
            set
            {
                this.isHypoallergenicFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isOilFree
        {
            get
            {
                return this.isOilFreeField;
            }
            set
            {
                this.isOilFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOilFreeSpecified
        {
            get
            {
                return this.isOilFreeFieldSpecified;
            }
            set
            {
                this.isOilFreeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isParabenFree
        {
            get
            {
                return this.isParabenFreeField;
            }
            set
            {
                this.isParabenFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isParabenFreeSpecified
        {
            get
            {
                return this.isParabenFreeFieldSpecified;
            }
            set
            {
                this.isParabenFreeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isNoncomodegenic
        {
            get
            {
                return this.isNoncomodegenicField;
            }
            set
            {
                this.isNoncomodegenicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNoncomodegenicSpecified
        {
            get
            {
                return this.isNoncomodegenicFieldSpecified;
            }
            set
            {
                this.isNoncomodegenicFieldSpecified = value;
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
        public bool isUnscented
        {
            get
            {
                return this.isUnscentedField;
            }
            set
            {
                this.isUnscentedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isUnscentedSpecified
        {
            get
            {
                return this.isUnscentedFieldSpecified;
            }
            set
            {
                this.isUnscentedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isVegan
        {
            get
            {
                return this.isVeganField;
            }
            set
            {
                this.isVeganField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVeganSpecified
        {
            get
            {
                return this.isVeganFieldSpecified;
            }
            set
            {
                this.isVeganFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isTinted
        {
            get
            {
                return this.isTintedField;
            }
            set
            {
                this.isTintedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTintedSpecified
        {
            get
            {
                return this.isTintedFieldSpecified;
            }
            set
            {
                this.isTintedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isSelfTanning
        {
            get
            {
                return this.isSelfTanningField;
            }
            set
            {
                this.isSelfTanningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSelfTanningSpecified
        {
            get
            {
                return this.isSelfTanningFieldSpecified;
            }
            set
            {
                this.isSelfTanningFieldSpecified = value;
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