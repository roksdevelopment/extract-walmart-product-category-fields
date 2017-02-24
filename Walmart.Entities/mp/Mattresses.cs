namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Mattresses
    {

        private string mattressFirmnessField;

        private LengthUnit mattressThicknessField;

        private bool pumpIncludedField;

        private bool pumpIncludedFieldSpecified;

        private string bedSizeField;

        /// <remarks/>
        public string mattressFirmness
        {
            get
            {
                return this.mattressFirmnessField;
            }
            set
            {
                this.mattressFirmnessField = value;
            }
        }

        /// <remarks/>
        public LengthUnit mattressThickness
        {
            get
            {
                return this.mattressThicknessField;
            }
            set
            {
                this.mattressThicknessField = value;
            }
        }

        /// <remarks/>
        public bool pumpIncluded
        {
            get
            {
                return this.pumpIncludedField;
            }
            set
            {
                this.pumpIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pumpIncludedSpecified
        {
            get
            {
                return this.pumpIncludedFieldSpecified;
            }
            set
            {
                this.pumpIncludedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string bedSize
        {
            get
            {
                return this.bedSizeField;
            }
            set
            {
                this.bedSizeField = value;
            }
        }
    }
}