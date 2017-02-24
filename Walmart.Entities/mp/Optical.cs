namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Optical
    {

        private string[] frameMaterialField;

        private string shapeField;

        private string eyewearFrameStyleField;

        private string lensMaterialField;

        private string eyewearFrameSizeField;

        private string uvRatingField;

        private bool isPolarizedField;

        private bool isPolarizedFieldSpecified;

        private string lensTintField;

        private bool isScratchResistantField;

        private bool isScratchResistantFieldSpecified;

        private bool hasAdaptiveLensesField;

        private bool hasAdaptiveLensesFieldSpecified;

        private string[] lensTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("frameMaterialValue", IsNullable = false)]
        public string[] frameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
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
        public string eyewearFrameStyle
        {
            get
            {
                return this.eyewearFrameStyleField;
            }
            set
            {
                this.eyewearFrameStyleField = value;
            }
        }

        /// <remarks/>
        public string lensMaterial
        {
            get
            {
                return this.lensMaterialField;
            }
            set
            {
                this.lensMaterialField = value;
            }
        }

        /// <remarks/>
        public string eyewearFrameSize
        {
            get
            {
                return this.eyewearFrameSizeField;
            }
            set
            {
                this.eyewearFrameSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string uvRating
        {
            get
            {
                return this.uvRatingField;
            }
            set
            {
                this.uvRatingField = value;
            }
        }

        /// <remarks/>
        public bool isPolarized
        {
            get
            {
                return this.isPolarizedField;
            }
            set
            {
                this.isPolarizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPolarizedSpecified
        {
            get
            {
                return this.isPolarizedFieldSpecified;
            }
            set
            {
                this.isPolarizedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string lensTint
        {
            get
            {
                return this.lensTintField;
            }
            set
            {
                this.lensTintField = value;
            }
        }

        /// <remarks/>
        public bool isScratchResistant
        {
            get
            {
                return this.isScratchResistantField;
            }
            set
            {
                this.isScratchResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isScratchResistantSpecified
        {
            get
            {
                return this.isScratchResistantFieldSpecified;
            }
            set
            {
                this.isScratchResistantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasAdaptiveLenses
        {
            get
            {
                return this.hasAdaptiveLensesField;
            }
            set
            {
                this.hasAdaptiveLensesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAdaptiveLensesSpecified
        {
            get
            {
                return this.hasAdaptiveLensesFieldSpecified;
            }
            set
            {
                this.hasAdaptiveLensesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("lensTypeValue", IsNullable = false)]
        public string[] lensType
        {
            get
            {
                return this.lensTypeField;
            }
            set
            {
                this.lensTypeField = value;
            }
        }
    }
}