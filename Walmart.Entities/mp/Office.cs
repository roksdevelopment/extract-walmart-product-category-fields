namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Office
    {

        private string[] inkColorField;

        private string numberOfSheetsField;

        private bool isRefillableField;

        private bool isRefillableFieldSpecified;

        private swatchImage[] swatchImagesField;

        private string systemOfMeasurementField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isAntiglareField;

        private bool isAntiglareFieldSpecified;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private string finishField;

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private bool isMagneticField;

        private bool isMagneticFieldSpecified;

        private string brandField;

        private decimal envelopeSizeField;

        private bool envelopeSizeFieldSpecified;

        private string conditionField;

        private LengthUnit holeSizeField;

        private string manufacturerField;

        private string[] themeField;

        private string[] paperSizeField;

        private string yearField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private string calendarFormatField;

        private TimeUnit calendarTermField;

        private string[] colorField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string[] ageGroupField;

        private string dexterityField;

        private string batterySizeField;

        private string[] materialField;

        private string[] patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string[] characterField;

        private string powerTypeField;

        private string[] occasionField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private string[] recommendedUsesField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isTearResistantField;

        private bool isTearResistantFieldSpecified;

        private string capacityField;

        private BrightnessUnit brightnessField;

        private string shapeField;

        private string[] compatibleDevicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("inkColorValue", IsNullable = false)]
        public string[] inkColor
        {
            get
            {
                return this.inkColorField;
            }
            set
            {
                this.inkColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfSheets
        {
            get
            {
                return this.numberOfSheetsField;
            }
            set
            {
                this.numberOfSheetsField = value;
            }
        }

        /// <remarks/>
        public bool isRefillable
        {
            get
            {
                return this.isRefillableField;
            }
            set
            {
                this.isRefillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRefillableSpecified
        {
            get
            {
                return this.isRefillableFieldSpecified;
            }
            set
            {
                this.isRefillableFieldSpecified = value;
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
        public string systemOfMeasurement
        {
            get
            {
                return this.systemOfMeasurementField;
            }
            set
            {
                this.systemOfMeasurementField = value;
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
        public bool isAntiglare
        {
            get
            {
                return this.isAntiglareField;
            }
            set
            {
                this.isAntiglareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiglareSpecified
        {
            get
            {
                return this.isAntiglareFieldSpecified;
            }
            set
            {
                this.isAntiglareFieldSpecified = value;
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
        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isMagnetic
        {
            get
            {
                return this.isMagneticField;
            }
            set
            {
                this.isMagneticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMagneticSpecified
        {
            get
            {
                return this.isMagneticFieldSpecified;
            }
            set
            {
                this.isMagneticFieldSpecified = value;
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
        public decimal envelopeSize
        {
            get
            {
                return this.envelopeSizeField;
            }
            set
            {
                this.envelopeSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool envelopeSizeSpecified
        {
            get
            {
                return this.envelopeSizeFieldSpecified;
            }
            set
            {
                this.envelopeSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        public LengthUnit holeSize
        {
            get
            {
                return this.holeSizeField;
            }
            set
            {
                this.holeSizeField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("paperSizeValue", IsNullable = false)]
        public string[] paperSize
        {
            get
            {
                return this.paperSizeField;
            }
            set
            {
                this.paperSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
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
        public string calendarFormat
        {
            get
            {
                return this.calendarFormatField;
            }
            set
            {
                this.calendarFormatField = value;
            }
        }

        /// <remarks/>
        public TimeUnit calendarTerm
        {
            get
            {
                return this.calendarTermField;
            }
            set
            {
                this.calendarTermField = value;
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
        public string dexterity
        {
            get
            {
                return this.dexterityField;
            }
            set
            {
                this.dexterityField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public string[] recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        /// <remarks/>
        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isTearResistant
        {
            get
            {
                return this.isTearResistantField;
            }
            set
            {
                this.isTearResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTearResistantSpecified
        {
            get
            {
                return this.isTearResistantFieldSpecified;
            }
            set
            {
                this.isTearResistantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        /// <remarks/>
        public BrightnessUnit brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        /// <remarks/>
        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public string[] compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }
    }
}