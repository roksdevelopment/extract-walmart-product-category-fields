namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class Animal {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnimalAccessories", typeof(AnimalAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("AnimalEverythingElse", typeof(AnimalEverythingElse))]
        [System.Xml.Serialization.XmlElementAttribute("AnimalFood", typeof(AnimalFood))]
        [System.Xml.Serialization.XmlElementAttribute("AnimalHealthAndGrooming", typeof(AnimalHealthAndGrooming))]
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