namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://walmart.com/content", IsNullable=false)]
    public partial class ContentProduct {
    
        private ContentProductSkuUpdate skuUpdateField;
    
        private bool skuUpdateFieldSpecified;
    
        private productIdentifier[] productIdentifiersField;
    
        private string skuField;
    
        private decimal msrpField;
    
        private bool msrpFieldSpecified;
    
        private string productNameField;
    
        private additionalProductAttribute[] additionalProductAttributesField;
    
        private category categoryField;
    
        /// <remarks/>
        public ContentProductSkuUpdate SkuUpdate {
            get {
                return this.skuUpdateField;
            }
            set {
                this.skuUpdateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SkuUpdateSpecified {
            get {
                return this.skuUpdateFieldSpecified;
            }
            set {
                this.skuUpdateFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public productIdentifier[] productIdentifiers {
            get {
                return this.productIdentifiersField;
            }
            set {
                this.productIdentifiersField = value;
            }
        }
    
        /// <remarks/>
        public string sku {
            get {
                return this.skuField;
            }
            set {
                this.skuField = value;
            }
        }
    
        /// <remarks/>
        public decimal msrp {
            get {
                return this.msrpField;
            }
            set {
                this.msrpField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool msrpSpecified {
            get {
                return this.msrpFieldSpecified;
            }
            set {
                this.msrpFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public string productName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public additionalProductAttribute[] additionalProductAttributes {
            get {
                return this.additionalProductAttributesField;
            }
            set {
                this.additionalProductAttributesField = value;
            }
        }
    
        /// <remarks/>
        public category category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
    }
}