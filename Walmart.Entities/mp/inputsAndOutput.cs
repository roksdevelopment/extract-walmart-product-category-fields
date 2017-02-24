namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class inputsAndOutput
    {

        private string inputOutputTypeField;

        private string inputOutputQuantityField;

        /// <remarks/>
        public string inputOutputType
        {
            get
            {
                return this.inputOutputTypeField;
            }
            set
            {
                this.inputOutputTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string inputOutputQuantity
        {
            get
            {
                return this.inputOutputQuantityField;
            }
            set
            {
                this.inputOutputQuantityField = value;
            }
        }
    }
}