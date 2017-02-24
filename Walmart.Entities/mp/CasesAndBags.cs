namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class CasesAndBags
    {

        private string finishField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private string[] occasionField;

        private string[] recommendedUsesField;

        private string bagStyleField;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private string fastenerTypeField;

        private string numberOfCompartmentsField;

        private bool hasRemovableStrapField;

        private bool hasRemovableStrapFieldSpecified;

        private bool isTsaApprovedField;

        private bool isTsaApprovedFieldSpecified;

        private string[] sportField;

        private WeightUnit maximumWeightField;

        private string shapeField;

        private LengthUnit screenSizeField;

        private string[] compatibleBrandsField;

        private string[] compatibleDevicesField;

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
        public string bagStyle
        {
            get
            {
                return this.bagStyleField;
            }
            set
            {
                this.bagStyleField = value;
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
        public string fastenerType
        {
            get
            {
                return this.fastenerTypeField;
            }
            set
            {
                this.fastenerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfCompartments
        {
            get
            {
                return this.numberOfCompartmentsField;
            }
            set
            {
                this.numberOfCompartmentsField = value;
            }
        }

        /// <remarks/>
        public bool hasRemovableStrap
        {
            get
            {
                return this.hasRemovableStrapField;
            }
            set
            {
                this.hasRemovableStrapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasRemovableStrapSpecified
        {
            get
            {
                return this.hasRemovableStrapFieldSpecified;
            }
            set
            {
                this.hasRemovableStrapFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isTsaApproved
        {
            get
            {
                return this.isTsaApprovedField;
            }
            set
            {
                this.isTsaApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTsaApprovedSpecified
        {
            get
            {
                return this.isTsaApprovedFieldSpecified;
            }
            set
            {
                this.isTsaApprovedFieldSpecified = value;
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
        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
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