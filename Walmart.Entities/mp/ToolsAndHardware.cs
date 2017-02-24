namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class ToolsAndHardware
    {

        private swatchImage[] swatchImagesField;

        private string[] accessoriesIncludedField;

        private string variantGroupIdField;

        private string[] variantAttributeNamesField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private bool isFireResistantField;

        private bool isFireResistantFieldSpecified;

        private string brandField;

        private string manufacturerField;

        private string[] colorField;

        private string[] materialField;

        private string numberOfPiecesField;

        private string cleaningCareAndMaintenanceField;

        private string[] recommendedUsesField;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private string shapeField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("accessoriesIncludedValue", IsNullable = false)]
        public string[] accessoriesIncluded
        {
            get
            {
                return this.accessoriesIncludedField;
            }
            set
            {
                this.accessoriesIncludedField = value;
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
        public bool isFireResistant
        {
            get
            {
                return this.isFireResistantField;
            }
            set
            {
                this.isFireResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFireResistantSpecified
        {
            get
            {
                return this.isFireResistantFieldSpecified;
            }
            set
            {
                this.isFireResistantFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPieces
        {
            get
            {
                return this.numberOfPiecesField;
            }
            set
            {
                this.numberOfPiecesField = value;
            }
        }

        /// <remarks/>
        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("BuildingSupply", typeof(BuildingSupply))]
        [System.Xml.Serialization.XmlElementAttribute("Electrical", typeof(Electrical))]
        [System.Xml.Serialization.XmlElementAttribute("Hardware", typeof(Hardware))]
        [System.Xml.Serialization.XmlElementAttribute("PlumbingAndHVAC", typeof(PlumbingAndHVAC))]
        [System.Xml.Serialization.XmlElementAttribute("Tools", typeof(Tools))]
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