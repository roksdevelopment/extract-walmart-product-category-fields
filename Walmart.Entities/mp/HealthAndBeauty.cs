namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class HealthAndBeauty
    {

        private swatchImage[] swatchImagesField;

        private string collectionField;

        private string[] variantAttributeNamesField;

        private bool flexibleSpendingAccountEligibleField;

        private bool flexibleSpendingAccountEligibleFieldSpecified;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string[] fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private HealthAndBeautyGender genderField;

        private bool genderFieldSpecified;

        private string[] colorField;

        private string[] ageGroupField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private string[] materialField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private string[] characterField;

        private string powerTypeField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private string[] bodyPartsField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private string cleaningCareAndMaintenanceField;

        private bool isSetField;

        private bool isSetFieldSpecified;

        private bool isTravelSizeField;

        private bool isTravelSizeFieldSpecified;

        private string[] recommendedUsesField;

        private string shapeField;

        private string[] compatibleBrandsField;

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
        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
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
        public bool flexibleSpendingAccountEligible
        {
            get
            {
                return this.flexibleSpendingAccountEligibleField;
            }
            set
            {
                this.flexibleSpendingAccountEligibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool flexibleSpendingAccountEligibleSpecified
        {
            get
            {
                return this.flexibleSpendingAccountEligibleFieldSpecified;
            }
            set
            {
                this.flexibleSpendingAccountEligibleFieldSpecified = value;
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
        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
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
        public HealthAndBeautyGender gender
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
        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
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
        public bool isSet
        {
            get
            {
                return this.isSetField;
            }
            set
            {
                this.isSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSetSpecified
        {
            get
            {
                return this.isSetFieldSpecified;
            }
            set
            {
                this.isSetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isTravelSize
        {
            get
            {
                return this.isTravelSizeField;
            }
            set
            {
                this.isTravelSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTravelSizeSpecified
        {
            get
            {
                return this.isTravelSizeFieldSpecified;
            }
            set
            {
                this.isTravelSizeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public string[] compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HealthAndBeautyElectronics", typeof(HealthAndBeautyElectronics))]
        [System.Xml.Serialization.XmlElementAttribute("MedicalAids", typeof(MedicalAids))]
        [System.Xml.Serialization.XmlElementAttribute("MedicineAndSupplements", typeof(MedicineAndSupplements))]
        [System.Xml.Serialization.XmlElementAttribute("Optical", typeof(Optical))]
        [System.Xml.Serialization.XmlElementAttribute("PersonalCare", typeof(PersonalCare))]
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