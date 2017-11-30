namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class OtherCategory {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CleaningAndChemical", typeof(CleaningAndChemical))]
        [System.Xml.Serialization.XmlElementAttribute("Other", typeof(Other))]
        [System.Xml.Serialization.XmlElementAttribute("Storage", typeof(Storage))]
        [System.Xml.Serialization.XmlElementAttribute("fuelsAndLubricants", typeof(fuelsAndLubricants))]
        [System.Xml.Serialization.XmlElementAttribute("giftCards", typeof(giftCards))]
        [System.Xml.Serialization.XmlElementAttribute("safetyAndEmergency", typeof(safetyAndEmergency))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}