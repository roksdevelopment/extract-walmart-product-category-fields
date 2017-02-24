namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BabyToys
    {

        private string animalBreedField;

        private BabyToysAgeRange ageRangeField;

        private bool ageRangeFieldSpecified;

        private string[] themeField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string[] awardsWonField;

        private string animalTypeField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private string[] fillMaterialField;

        private string[] educationalFocusField;

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
        public BabyToysAgeRange ageRange
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
        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
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
        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public string[] fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
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
    }
}