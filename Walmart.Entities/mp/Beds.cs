namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Beds
    {

        private string bedStyleField;

        private string bedSizeField;

        /// <remarks/>
        public string bedStyle
        {
            get
            {
                return this.bedStyleField;
            }
            set
            {
                this.bedStyleField = value;
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