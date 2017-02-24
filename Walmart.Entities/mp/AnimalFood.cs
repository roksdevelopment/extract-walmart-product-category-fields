namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class AnimalFood
    {

        private string flavorField;

        private string petFoodFormField;

        private string[] nutrientContentClaimsField;

        private bool isGrainFreeField;

        private bool isGrainFreeFieldSpecified;

        private string feedingInstructionsField;

        private string animalHealthConcernField;

        private string ingredientsField;

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
        public string petFoodForm
        {
            get
            {
                return this.petFoodFormField;
            }
            set
            {
                this.petFoodFormField = value;
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
        public bool isGrainFree
        {
            get
            {
                return this.isGrainFreeField;
            }
            set
            {
                this.isGrainFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isGrainFreeSpecified
        {
            get
            {
                return this.isGrainFreeFieldSpecified;
            }
            set
            {
                this.isGrainFreeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string feedingInstructions
        {
            get
            {
                return this.feedingInstructionsField;
            }
            set
            {
                this.feedingInstructionsField = value;
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
    }
}