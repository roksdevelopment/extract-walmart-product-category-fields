namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class Baby {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BabyClothing", typeof(BabyClothing))]
        [System.Xml.Serialization.XmlElementAttribute("BabyFood", typeof(BabyFood))]
        [System.Xml.Serialization.XmlElementAttribute("BabyFurniture", typeof(BabyFurniture))]
        [System.Xml.Serialization.XmlElementAttribute("BabyOther", typeof(BabyOther))]
        [System.Xml.Serialization.XmlElementAttribute("BabyToys", typeof(BabyToys))]
        [System.Xml.Serialization.XmlElementAttribute("ChildCarSeats", typeof(ChildCarSeats))]
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