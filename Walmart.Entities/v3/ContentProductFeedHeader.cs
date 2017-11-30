namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://walmart.com/content", IsNullable=false)]
    public partial class ContentProductFeedHeader {
    
        private ContentProductFeedHeaderVersion versionField;
    
        private string requestIdField;
    
        private string requestBatchIdField;
    
        private System.DateTime feedDateField;
    
        private bool feedDateFieldSpecified;
    
        private ContentProductFeedHeaderMart martField;
    
        private bool martFieldSpecified;
    
        public ContentProductFeedHeader() {
            this.versionField = ContentProductFeedHeaderVersion.Item30;
        }
    
        /// <remarks/>
        public ContentProductFeedHeaderVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    
        /// <remarks/>
        public string requestId {
            get {
                return this.requestIdField;
            }
            set {
                this.requestIdField = value;
            }
        }
    
        /// <remarks/>
        public string requestBatchId {
            get {
                return this.requestBatchIdField;
            }
            set {
                this.requestBatchIdField = value;
            }
        }
    
        /// <remarks/>
        public System.DateTime feedDate {
            get {
                return this.feedDateField;
            }
            set {
                this.feedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool feedDateSpecified {
            get {
                return this.feedDateFieldSpecified;
            }
            set {
                this.feedDateFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public ContentProductFeedHeaderMart mart {
            get {
                return this.martField;
            }
            set {
                this.martField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool martSpecified {
            get {
                return this.martFieldSpecified;
            }
            set {
                this.martFieldSpecified = value;
            }
        }
    }
}