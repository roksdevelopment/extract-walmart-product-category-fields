namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Animal
    {

        private string animalBreedField;

        private swatchImage[] swatchImagesField;

        private string animalLifestageField;

        private WeightUnit minimumWeightField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private string[] fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private string[] colorField;

        private string animalTypeField;

        private string[] materialField;

        private string[] patternField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private WeightUnit maximumWeightField;

        private string petSizeField;

        private object itemField;

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
        public string animalLifestage
        {
            get
            {
                return this.animalLifestageField;
            }
            set
            {
                this.animalLifestageField = value;
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
        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnimalAccessories", typeof(AnimalAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("AnimalFood", typeof(AnimalFood))]
        [System.Xml.Serialization.XmlElementAttribute("AnimalHealthAndGrooming", typeof(AnimalHealthAndGrooming))]
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