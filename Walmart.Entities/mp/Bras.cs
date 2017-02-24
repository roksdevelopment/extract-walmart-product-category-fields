namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Bras
    {

        private string braStyleField;

        private BraSize braSizeField;

        /// <remarks/>
        public string braStyle
        {
            get
            {
                return this.braStyleField;
            }
            set
            {
                this.braStyleField = value;
            }
        }

        /// <remarks/>
        public BraSize braSize
        {
            get
            {
                return this.braSizeField;
            }
            set
            {
                this.braSizeField = value;
            }
        }
    }
}