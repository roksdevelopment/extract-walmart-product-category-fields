namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Clothing
    {

        private swatchImage[] swatchImagesField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private string[] fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string clothingSizeField;

        private ClothingGender genderField;

        private bool genderFieldSpecified;

        private string[] colorField;

        private string[] ageGroupField;

        private ClothingClothingSizeType clothingSizeTypeField;

        private bool clothingSizeTypeFieldSpecified;

        private bool isMaternityField;

        private bool isMaternityFieldSpecified;

        private string[] patternField;

        private string[] characterField;

        private string[] occasionField;

        private ClothingApparelCategory apparelCategoryField;

        private bool apparelCategoryFieldSpecified;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private bool gotsCertificationField;

        private bool gotsCertificationFieldSpecified;

        private string[] seasonField;

        private string[] sportField;

        private object itemField;

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
        public ClothingGender gender
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
        public ClothingClothingSizeType clothingSizeType
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
        public bool isMaternity
        {
            get
            {
                return this.isMaternityField;
            }
            set
            {
                this.isMaternityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMaternitySpecified
        {
            get
            {
                return this.isMaternityFieldSpecified;
            }
            set
            {
                this.isMaternityFieldSpecified = value;
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
        public ClothingApparelCategory apparelCategory
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
        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public recycledMaterialContentValue[] recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        /// <remarks/>
        public bool gotsCertification
        {
            get
            {
                return this.gotsCertificationField;
            }
            set
            {
                this.gotsCertificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gotsCertificationSpecified
        {
            get
            {
                return this.gotsCertificationFieldSpecified;
            }
            set
            {
                this.gotsCertificationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("seasonValue", IsNullable = false)]
        public string[] season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public string[] sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bras", typeof(Bras))]
        [System.Xml.Serialization.XmlElementAttribute("ClothingAccessories", typeof(ClothingAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("DressShirts", typeof(DressShirts))]
        [System.Xml.Serialization.XmlElementAttribute("Dresses", typeof(Dresses))]
        [System.Xml.Serialization.XmlElementAttribute("Panties", typeof(Panties))]
        [System.Xml.Serialization.XmlElementAttribute("PantsAndShorts", typeof(PantsAndShorts))]
        [System.Xml.Serialization.XmlElementAttribute("ShirtsAndTops", typeof(ShirtsAndTops))]
        [System.Xml.Serialization.XmlElementAttribute("Skirts", typeof(Skirts))]
        [System.Xml.Serialization.XmlElementAttribute("Socks", typeof(Socks))]
        [System.Xml.Serialization.XmlElementAttribute("WomensSwimsuits", typeof(WomensSwimsuits))]
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