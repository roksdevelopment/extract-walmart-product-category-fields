namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class certificationsAndClaim
    {

        private string certificationAndClaimTypeField;

        private string certifyingAgentField;

        /// <remarks/>
        public string certificationAndClaimType
        {
            get
            {
                return this.certificationAndClaimTypeField;
            }
            set
            {
                this.certificationAndClaimTypeField = value;
            }
        }

        /// <remarks/>
        public string certifyingAgent
        {
            get
            {
                return this.certifyingAgentField;
            }
            set
            {
                this.certifyingAgentField = value;
            }
        }
    }
}