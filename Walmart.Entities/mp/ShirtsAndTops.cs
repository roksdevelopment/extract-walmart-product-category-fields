namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class ShirtsAndTops
    {

        private string shirtSizeField;

        private string shirtNeckStyleField;

        private string sleeveStyleField;

        /// <remarks/>
        public string shirtSize
        {
            get
            {
                return this.shirtSizeField;
            }
            set
            {
                this.shirtSizeField = value;
            }
        }

        /// <remarks/>
        public string shirtNeckStyle
        {
            get
            {
                return this.shirtNeckStyleField;
            }
            set
            {
                this.shirtNeckStyleField = value;
            }
        }

        /// <remarks/>
        public string sleeveStyle
        {
            get
            {
                return this.sleeveStyleField;
            }
            set
            {
                this.sleeveStyleField = value;
            }
        }
    }
}