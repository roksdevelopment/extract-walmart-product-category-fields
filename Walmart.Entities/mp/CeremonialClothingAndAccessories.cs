namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class CeremonialClothingAndAccessories
    {

        private fabricContentValue[] fabricContentField;

        private string[] fabricCareInstructionsField;

        private string clothingSizeField;

        private CeremonialClothingAndAccessoriesGender genderField;

        private bool genderFieldSpecified;

        private CeremonialClothingAndAccessoriesClothingSizeType clothingSizeTypeField;

        private bool clothingSizeTypeFieldSpecified;

        private string[] patternField;

        private CeremonialClothingAndAccessoriesApparelCategory apparelCategoryField;

        private bool apparelCategoryFieldSpecified;

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
        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        /// <remarks/>
        public CeremonialClothingAndAccessoriesGender gender
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
        public CeremonialClothingAndAccessoriesClothingSizeType clothingSizeType
        {
            get
            {
                return this.clothingSizeTypeField;
            }
            set
            {
                this.clothingSizeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clothingSizeTypeSpecified
        {
            get
            {
                return this.clothingSizeTypeFieldSpecified;
            }
            set
            {
                this.clothingSizeTypeFieldSpecified = value;
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
        public CeremonialClothingAndAccessoriesApparelCategory apparelCategory
        {
            get
            {
                return this.apparelCategoryField;
            }
            set
            {
                this.apparelCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apparelCategorySpecified
        {
            get
            {
                return this.apparelCategoryFieldSpecified;
            }
            set
            {
                this.apparelCategoryFieldSpecified = value;
            }
        }
    }
}