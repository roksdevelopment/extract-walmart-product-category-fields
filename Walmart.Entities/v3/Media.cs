namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class Media {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BooksAndMagazines", typeof(BooksAndMagazines))]
        [System.Xml.Serialization.XmlElementAttribute("Movies", typeof(Movies))]
        [System.Xml.Serialization.XmlElementAttribute("Music", typeof(Music))]
        [System.Xml.Serialization.XmlElementAttribute("TVShows", typeof(TVShows))]
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