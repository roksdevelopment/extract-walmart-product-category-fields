namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MedicalAids
    {

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private LengthUnit diameterField;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private WeightUnit maximumWeightField;

        private bool isLatexFreeField;

        private bool isLatexFreeFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private string[] healthConcernsField;

        /// <remarks/>
        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
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
        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        /// <remarks/>
        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
        {
            get
            {
                return this.isAssemblyRequiredFieldSpecified;
            }
            set
            {
                this.isAssemblyRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string assemblyInstructions
        {
            get
            {
                return this.assemblyInstructionsField;
            }
            set
            {
                this.assemblyInstructionsField = value;
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
        public bool isLatexFree
        {
            get
            {
                return this.isLatexFreeField;
            }
            set
            {
                this.isLatexFreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLatexFreeSpecified
        {
            get
            {
                return this.isLatexFreeFieldSpecified;
            }
            set
            {
                this.isLatexFreeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("healthConcern", IsNullable = false)]
        public string[] healthConcerns
        {
            get
            {
                return this.healthConcernsField;
            }
            set
            {
                this.healthConcernsField = value;
            }
        }
    }
}