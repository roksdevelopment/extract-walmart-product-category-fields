namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BabyFootwear
    {

        private string shoeCategoryField;

        private string shoeSizeField;

        private string shoeWidthField;

        private BabyFootwearGender genderField;

        private bool genderFieldSpecified;

        private string shoeStyleField;

        private string[] ageGroupField;

        private string shoeClosureField;

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
        public BabyFootwearGender gender
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
    }
}