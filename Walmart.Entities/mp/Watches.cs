namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Watches
    {

        private string[] watchBandMaterialField;

        private string metalField;

        private string watchCaseShapeField;

        private string platingField;

        private swatchImage[] swatchImagesField;

        private string[] watchStyleField;

        private string[] gemstoneField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private string gemstoneShapeField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private WeightUnit caratsField;

        private fabricContentValue[] fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private string finishField;

        private string brandField;

        private string manufacturerField;

        private string[] themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private WatchesGender genderField;

        private string[] colorField;

        private string[] ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string[] materialField;

        private string[] patternField;

        private string[] characterField;

        private string powerTypeField;

        private string[] occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private string displayTechnologyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("watchBandMaterialValue", IsNullable = false)]
        public string[] watchBandMaterial
        {
            get
            {
                return this.watchBandMaterialField;
            }
            set
            {
                this.watchBandMaterialField = value;
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
        public string watchCaseShape
        {
            get
            {
                return this.watchCaseShapeField;
            }
            set
            {
                this.watchCaseShapeField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("watchStyleValue", IsNullable = false)]
        public string[] watchStyle
        {
            get
            {
                return this.watchStyleField;
            }
            set
            {
                this.watchStyleField = value;
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
        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
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
        public WatchesGender gender
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
        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }
    }
}