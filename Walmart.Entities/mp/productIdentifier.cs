namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class productIdentifier
    {

        private productIdentifierProductIdType productIdTypeField;

        private string productIdField;

        /// <remarks/>
        public productIdentifierProductIdType productIdType
        {
            get
            {
                return this.productIdTypeField;
            }
            set
            {
                this.productIdTypeField = value;
            }
        }

        /// <remarks/>
        public string productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
    }
}