namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Jewelry
    {

        private string sizeField;

        private JewelryJewelryStyle jewelryStyleField;

        private string metalField;

        private string platingField;

        private swatchImage[] swatchImagesField;

        private string karatsField;

        private string[] gemstoneField;

        private string[] variantAttributeNamesField;

        private string birthstoneField;

        private string variantGroupIdField;

        private string gemstoneShapeField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private WeightUnit caratsField;

        private string diamondClarityField;

        private string gemstoneCutField;

        private LengthUnit chainLengthField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private JewelryGender genderField;

        private string[] colorField;

        private string[] ageGroupField;

        private string[] materialField;

        private string[] patternField;

        private string[] characterField;

        private string[] occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private string[] bodyPartsField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private Rings itemField;

        /// <remarks/>
        public string size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public JewelryJewelryStyle jewelryStyle
        {
            get
            {
                return this.jewelryStyleField;
            }
            set
            {
                this.jewelryStyleField = value;
            }
        }

        /// <remarks/>
        public string metal
        {
            get
            {
                return this.metalField;
            }
            set
            {
                this.metalField = value;
            }
        }

        /// <remarks/>
        public string plating
        {
            get
            {
                return this.platingField;
            }
            set
            {
                this.platingField = value;
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
        public string karats
        {
            get
            {
                return this.karatsField;
            }
            set
            {
                this.karatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("gemstoneValue", IsNullable = false)]
        public string[] gemstone
        {
            get
            {
                return this.gemstoneField;
            }
            set
            {
                this.gemstoneField = value;
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
        public string birthstone
        {
            get
            {
                return this.birthstoneField;
            }
            set
            {
                this.birthstoneField = value;
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
        public string gemstoneShape
        {
            get
            {
                return this.gemstoneShapeField;
            }
            set
            {
                this.gemstoneShapeField = value;
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
        public WeightUnit carats
        {
            get
            {
                return this.caratsField;
            }
            set
            {
                this.caratsField = value;
            }
        }

        /// <remarks/>
        public string diamondClarity
        {
            get
            {
                return this.diamondClarityField;
            }
            set
            {
                this.diamondClarityField = value;
            }
        }

        /// <remarks/>
        public string gemstoneCut
        {
            get
            {
                return this.gemstoneCutField;
            }
            set
            {
                this.gemstoneCutField = value;
            }
        }

        /// <remarks/>
        public LengthUnit chainLength
        {
            get
            {
                return this.chainLengthField;
            }
            set
            {
                this.chainLengthField = value;
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
        public JewelryGender gender
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
        [System.Xml.Serialization.XmlArrayItemAttribute("bodyPart", IsNullable = false)]
        public string[] bodyParts
        {
            get
            {
                return this.bodyPartsField;
            }
            set
            {
                this.bodyPartsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Rings")]
        public Rings Item
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