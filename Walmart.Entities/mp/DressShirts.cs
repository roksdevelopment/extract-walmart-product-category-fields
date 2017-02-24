namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class DressShirts
    {

        private DressShirtSize dressShirtSizeField;

        private string collarTypeField;

        private string sleeveStyleField;

        /// <remarks/>
        public DressShirtSize dressShirtSize
        {
            get
            {
                return this.dressShirtSizeField;
            }
            set
            {
                this.dressShirtSizeField = value;
            }
        }

        /// <remarks/>
        public string collarType
        {
            get
            {
                return this.collarTypeField;
            }
            set
            {
                this.collarTypeField = value;
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