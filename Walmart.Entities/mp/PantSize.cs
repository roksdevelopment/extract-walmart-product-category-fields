namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class PantSize
    {

        private decimal inseamField;

        private bool inseamFieldSpecified;

        private LengthUnit waistSizeField;

        /// <remarks/>
        public decimal inseam
        {
            get
            {
                return this.inseamField;
            }
            set
            {
                this.inseamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inseamSpecified
        {
            get
            {
                return this.inseamFieldSpecified;
            }
            set
            {
                this.inseamFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LengthUnit waistSize
        {
            get
            {
                return this.waistSizeField;
            }
            set
            {
                this.waistSizeField = value;
            }
        }
    }
}