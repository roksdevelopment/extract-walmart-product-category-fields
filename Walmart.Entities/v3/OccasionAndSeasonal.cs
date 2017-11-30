namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class OccasionAndSeasonal {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CeremonialClothingAndAccessories", typeof(CeremonialClothingAndAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("Costumes", typeof(Costumes))]
        [System.Xml.Serialization.XmlElementAttribute("DecorationsAndFavors", typeof(DecorationsAndFavors))]
        [System.Xml.Serialization.XmlElementAttribute("Funeral", typeof(Funeral))]
        [System.Xml.Serialization.XmlElementAttribute("GiftSupplyAndAwards", typeof(GiftSupplyAndAwards))]
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