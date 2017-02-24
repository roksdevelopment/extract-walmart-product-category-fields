namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://walmart.com/", IsNullable = false)]
    public partial class OfferEnvelope
    {

        private Mart martField;

        private bool martFieldSpecified;

        private string skuField;

        private string wpidField;

        private System.DateTime launchDateField;

        private bool launchDateFieldSpecified;

        private System.DateTime discontinueDateField;

        private bool discontinueDateFieldSpecified;

        private Money priceField;

        private Money minAdvertisedPriceField;

        private bool isMustShipAloneField;

        private WeightMeasure shippingWeightField;

        private MPItemShippingOverride[] shippingOverridesField;

        public OfferEnvelope()
        {
            this.isMustShipAloneField = false;
        }

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
        public System.DateTime launchDate
        {
            get
            {
                return this.launchDateField;
            }
            set
            {
                this.launchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool launchDateSpecified
        {
            get
            {
                return this.launchDateFieldSpecified;
            }
            set
            {
                this.launchDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime discontinueDate
        {
            get
            {
                return this.discontinueDateField;
            }
            set
            {
                this.discontinueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discontinueDateSpecified
        {
            get
            {
                return this.discontinueDateFieldSpecified;
            }
            set
            {
                this.discontinueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Money price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public Money minAdvertisedPrice
        {
            get
            {
                return this.minAdvertisedPriceField;
            }
            set
            {
                this.minAdvertisedPriceField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isMustShipAlone
        {
            get
            {
                return this.isMustShipAloneField;
            }
            set
            {
                this.isMustShipAloneField = value;
            }
        }

        /// <remarks/>
        public WeightMeasure shippingWeight
        {
            get
            {
                return this.shippingWeightField;
            }
            set
            {
                this.shippingWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("shippingOverride", IsNullable = false)]
        public MPItemShippingOverride[] shippingOverrides
        {
            get
            {
                return this.shippingOverridesField;
            }
            set
            {
                this.shippingOverridesField = value;
            }
        }
    }
}