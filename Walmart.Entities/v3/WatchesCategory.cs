namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class WatchesCategory {
    
        private Watches itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Watches")]
        public Watches Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}