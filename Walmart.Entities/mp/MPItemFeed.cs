namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://walmart.com/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://walmart.com/", IsNullable = false)]
    public partial class MPItemFeed
    {

        private MPItemFeedHeader mPItemFeedHeaderField;

        private object[] itemsField;

        /// <remarks/>
        public MPItemFeedHeader MPItemFeedHeader
        {
            get
            {
                return this.mPItemFeedHeaderField;
            }
            set
            {
                this.mPItemFeedHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MPItem", typeof(MPItem))]
        [System.Xml.Serialization.XmlElementAttribute("MPItemUpdate", typeof(MPItemUpdate))]
        [System.Xml.Serialization.XmlElementAttribute("OfferEnvelope", typeof(OfferEnvelope))]
        [System.Xml.Serialization.XmlElementAttribute("ProductEnvelope", typeof(ProductEnvelope))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}