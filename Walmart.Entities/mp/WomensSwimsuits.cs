namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class WomensSwimsuits
    {

        private BraSize braSizeField;

        private string swimsuitStyleField;

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

        /// <remarks/>
        public string swimsuitStyle
        {
            get
            {
                return this.swimsuitStyleField;
            }
            set
            {
                this.swimsuitStyleField = value;
            }
        }
    }
}