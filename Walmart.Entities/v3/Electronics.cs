namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class Electronics {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CellPhones", typeof(CellPhones))]
        [System.Xml.Serialization.XmlElementAttribute("ComputerComponents", typeof(ComputerComponents))]
        [System.Xml.Serialization.XmlElementAttribute("Computers", typeof(Computers))]
        [System.Xml.Serialization.XmlElementAttribute("ElectronicsAccessories", typeof(ElectronicsAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("ElectronicsCables", typeof(ElectronicsCables))]
        [System.Xml.Serialization.XmlElementAttribute("ElectronicsOther", typeof(ElectronicsOther))]
        [System.Xml.Serialization.XmlElementAttribute("PrintersScannersAndImaging", typeof(PrintersScannersAndImaging))]
        [System.Xml.Serialization.XmlElementAttribute("Software", typeof(Software))]
        [System.Xml.Serialization.XmlElementAttribute("TVsAndVideoDisplays", typeof(TVsAndVideoDisplays))]
        [System.Xml.Serialization.XmlElementAttribute("VideoGames", typeof(VideoGames))]
        [System.Xml.Serialization.XmlElementAttribute("VideoProjectors", typeof(VideoProjectors))]
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