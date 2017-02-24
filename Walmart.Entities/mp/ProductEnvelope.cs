namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://walmart.com/", IsNullable = false)]
    public partial class ProductEnvelope
    {

        private Mart martField;

        private bool martFieldSpecified;

        private string skuField;

        private string wpidField;

        private MPProduct productField;

        /// <remarks/>
        public Mart mart
        {
            get
            {
                return this.martField;
            }
            set
            {
                this.martField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool martSpecified
        {
            get
            {
                return this.martFieldSpecified;
            }
            set
            {
                this.martFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        /// <remarks/>
        public string wpid
        {
            get
            {
                return this.wpidField;
            }
            set
            {
                this.wpidField = value;
            }
        }

        /// <remarks/>
        public MPProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }
}