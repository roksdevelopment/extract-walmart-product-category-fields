namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class JewelryCategory {
    
        private Jewelry itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Jewelry")]
        public Jewelry Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}