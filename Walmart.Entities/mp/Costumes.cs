namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Costumes
    {

        private fabricContentValue[] fabricContentField;

        private string[] fabricCareInstructionsField;

        private string[] themeField;

        private string clothingSizeField;

        private CostumesGender genderField;

        private bool genderFieldSpecified;

        private string[] ageGroupField;

        private CostumesClothingSizeType clothingSizeTypeField;

        private bool clothingSizeTypeFieldSpecified;

        private string animalTypeField;

        private string[] characterField;

        private string[] targetAudienceField;

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
        public CostumesGender gender
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
        public CostumesClothingSizeType clothingSizeType
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
    }
}