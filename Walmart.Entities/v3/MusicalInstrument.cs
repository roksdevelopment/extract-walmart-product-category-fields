namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class MusicalInstrument {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstrumentAccessories", typeof(InstrumentAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("MusicCasesAndBags", typeof(MusicCasesAndBags))]
        [System.Xml.Serialization.XmlElementAttribute("MusicalInstruments", typeof(MusicalInstruments))]
        [System.Xml.Serialization.XmlElementAttribute("SoundAndRecording", typeof(SoundAndRecording))]
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