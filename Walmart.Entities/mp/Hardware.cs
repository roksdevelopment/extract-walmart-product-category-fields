namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Hardware
    {

        private string finishField;

        private string homeDecorStyleField;

        private string[] mountTypeField;

        private WeightUnit maximumWeightField;

        private LengthUnit backsetSizeField;

        private LengthUnit liftHeightField;

        private bool isLockableField;

        private bool isLockableFieldSpecified;

        private WeightUnit maximumForceResistedField;

        private string petSizeField;

        private string threadStandardField;

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
        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public string[] mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
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
        public LengthUnit backsetSize
        {
            get
            {
                return this.backsetSizeField;
            }
            set
            {
                this.backsetSizeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit liftHeight
        {
            get
            {
                return this.liftHeightField;
            }
            set
            {
                this.liftHeightField = value;
            }
        }

        /// <remarks/>
        public bool isLockable
        {
            get
            {
                return this.isLockableField;
            }
            set
            {
                this.isLockableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLockableSpecified
        {
            get
            {
                return this.isLockableFieldSpecified;
            }
            set
            {
                this.isLockableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public WeightUnit maximumForceResisted
        {
            get
            {
                return this.maximumForceResistedField;
            }
            set
            {
                this.maximumForceResistedField = value;
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
        public string threadStandard
        {
            get
            {
                return this.threadStandardField;
            }
            set
            {
                this.threadStandardField = value;
            }
        }
    }
}