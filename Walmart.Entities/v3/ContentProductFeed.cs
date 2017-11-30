namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://walmart.com/content")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://walmart.com/content", IsNullable=false)]
    public partial class ContentProductFeed {
    
        private ContentProductFeedHeader contentProductFeedHeaderField;
    
        private ContentProduct[] contentProductField;
    
        /// <remarks/>
        public ContentProductFeedHeader ContentProductFeedHeader {
            get {
                return this.contentProductFeedHeaderField;
            }
            set {
                this.contentProductFeedHeaderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentProduct")]
        public ContentProduct[] ContentProduct {
            get {
                return this.contentProductField;
            }
            set {
                this.contentProductField = value;
            }
        }
    }
}