namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Shoes
    {

        private string shoeCategoryField;

        private string shoeSizeField;

        private string shoeWidthField;

        private LengthUnit heelHeightField;

        private string shoeStyleField;

        private string casualAndDressShoeTypeField;

        private string shoeClosureField;

        private bool isWaterResistantField;

        private bool isWaterResistantFieldSpecified;

        private bool isOrthopedicField;

        private bool isOrthopedicFieldSpecified;

        /// <remarks/>
        public string shoeCategory
        {
            get
            {
                return this.shoeCategoryField;
            }
            set
            {
                this.shoeCategoryField = value;
            }
        }

        /// <remarks/>
        public string shoeSize
        {
            get
            {
                return this.shoeSizeField;
            }
            set
            {
                this.shoeSizeField = value;
            }
        }

        /// <remarks/>
        public string shoeWidth
        {
            get
            {
                return this.shoeWidthField;
            }
            set
            {
                this.shoeWidthField = value;
            }
        }

        /// <remarks/>
        public LengthUnit heelHeight
        {
            get
            {
                return this.heelHeightField;
            }
            set
            {
                this.heelHeightField = value;
            }
        }

        /// <remarks/>
        public string shoeStyle
        {
            get
            {
                return this.shoeStyleField;
            }
            set
            {
                this.shoeStyleField = value;
            }
        }

        /// <remarks/>
        public string casualAndDressShoeType
        {
            get
            {
                return this.casualAndDressShoeTypeField;
            }
            set
            {
                this.casualAndDressShoeTypeField = value;
            }
        }

        /// <remarks/>
        public string shoeClosure
        {
            get
            {
                return this.shoeClosureField;
            }
            set
            {
                this.shoeClosureField = value;
            }
        }

        /// <remarks/>
        public bool isWaterResistant
        {
            get
            {
                return this.isWaterResistantField;
            }
            set
            {
                this.isWaterResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterResistantSpecified
        {
            get
            {
                return this.isWaterResistantFieldSpecified;
            }
            set
            {
                this.isWaterResistantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isOrthopedic
        {
            get
            {
                return this.isOrthopedicField;
            }
            set
            {
                this.isOrthopedicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOrthopedicSpecified
        {
            get
            {
                return this.isOrthopedicFieldSpecified;
            }
            set
            {
                this.isOrthopedicFieldSpecified = value;
            }
        }
    }
}