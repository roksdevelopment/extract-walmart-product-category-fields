namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class ToolsAndHardware {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuildingSupply", typeof(BuildingSupply))]
        [System.Xml.Serialization.XmlElementAttribute("Electrical", typeof(Electrical))]
        [System.Xml.Serialization.XmlElementAttribute("Hardware", typeof(Hardware))]
        [System.Xml.Serialization.XmlElementAttribute("PlumbingAndHVAC", typeof(PlumbingAndHVAC))]
        [System.Xml.Serialization.XmlElementAttribute("Tools", typeof(Tools))]
        [System.Xml.Serialization.XmlElementAttribute("ToolsAndHardwareOther", typeof(ToolsAndHardwareOther))]
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