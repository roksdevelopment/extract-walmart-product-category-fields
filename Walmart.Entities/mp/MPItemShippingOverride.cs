namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MPItemShippingOverride
    {

        private bool isShippingAllowedField;

        private bool isShippingAllowedFieldSpecified;

        private ShipRegion shipRegionField;

        private ShipMethod shipMethodField;

        private double shipPriceField;

        private bool shipPriceFieldSpecified;

        /// <remarks/>
        public bool isShippingAllowed
        {
            get
            {
                return this.isShippingAllowedField;
            }
            set
            {
                this.isShippingAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isShippingAllowedSpecified
        {
            get
            {
                return this.isShippingAllowedFieldSpecified;
            }
            set
            {
                this.isShippingAllowedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ShipRegion shipRegion
        {
            get
            {
                return this.shipRegionField;
            }
            set
            {
                this.shipRegionField = value;
            }
        }

        /// <remarks/>
        public ShipMethod shipMethod
        {
            get
            {
                return this.shipMethodField;
            }
            set
            {
                this.shipMethodField = value;
            }
        }

        /// <remarks/>
        public double shipPrice
        {
            get
            {
                return this.shipPriceField;
            }
            set
            {
                this.shipPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipPriceSpecified
        {
            get
            {
                return this.shipPriceFieldSpecified;
            }
            set
            {
                this.shipPriceFieldSpecified = value;
            }
        }
    }
}