namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Socks
    {

        private string sockSizeField;

        private string sockStyleField;

        /// <remarks/>
        public string sockSize
        {
            get
            {
                return this.sockSizeField;
            }
            set
            {
                this.sockSizeField = value;
            }
        }

        /// <remarks/>
        public string sockStyle
        {
            get
            {
                return this.sockStyleField;
            }
            set
            {
                this.sockStyleField = value;
            }
        }
    }
}