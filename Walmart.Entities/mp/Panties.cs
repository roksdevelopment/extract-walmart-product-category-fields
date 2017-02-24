namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Panties
    {

        private string pantySizeField;

        private string pantyStyleField;

        /// <remarks/>
        public string pantySize
        {
            get
            {
                return this.pantySizeField;
            }
            set
            {
                this.pantySizeField = value;
            }
        }

        /// <remarks/>
        public string pantyStyle
        {
            get
            {
                return this.pantyStyleField;
            }
            set
            {
                this.pantyStyleField = value;
            }
        }
    }
}