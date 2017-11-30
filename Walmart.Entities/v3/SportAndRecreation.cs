namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class SportAndRecreation {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cycling", typeof(Cycling))]
        [System.Xml.Serialization.XmlElementAttribute("Optics", typeof(Optics))]
        [System.Xml.Serialization.XmlElementAttribute("SportAndRecreationOther", typeof(SportAndRecreationOther))]
        [System.Xml.Serialization.XmlElementAttribute("Weapons", typeof(Weapons))]
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