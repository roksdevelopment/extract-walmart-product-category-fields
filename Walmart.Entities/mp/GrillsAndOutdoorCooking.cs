namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class GrillsAndOutdoorCooking
    {

        private string flavorField;

        private string numberOfBurnersField;

        private bool hasSideShelfField;

        private bool hasSideShelfFieldSpecified;

        private bool hasCharcoalBasketField;

        private bool hasCharcoalBasketFieldSpecified;

        private AreaUnit totalCookingAreaField;

        private AreaUnit sideBurnerSizeField;

        private bool hasTankTrayField;

        private bool hasTankTrayFieldSpecified;

        private string lifespanField;

        /// <remarks/>
        public string flavor
        {
            get
            {
                return this.flavorField;
            }
            set
            {
                this.flavorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfBurners
        {
            get
            {
                return this.numberOfBurnersField;
            }
            set
            {
                this.numberOfBurnersField = value;
            }
        }

        /// <remarks/>
        public bool hasSideShelf
        {
            get
            {
                return this.hasSideShelfField;
            }
            set
            {
                this.hasSideShelfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSideShelfSpecified
        {
            get
            {
                return this.hasSideShelfFieldSpecified;
            }
            set
            {
                this.hasSideShelfFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasCharcoalBasket
        {
            get
            {
                return this.hasCharcoalBasketField;
            }
            set
            {
                this.hasCharcoalBasketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCharcoalBasketSpecified
        {
            get
            {
                return this.hasCharcoalBasketFieldSpecified;
            }
            set
            {
                this.hasCharcoalBasketFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AreaUnit totalCookingArea
        {
            get
            {
                return this.totalCookingAreaField;
            }
            set
            {
                this.totalCookingAreaField = value;
            }
        }

        /// <remarks/>
        public AreaUnit sideBurnerSize
        {
            get
            {
                return this.sideBurnerSizeField;
            }
            set
            {
                this.sideBurnerSizeField = value;
            }
        }

        /// <remarks/>
        public bool hasTankTray
        {
            get
            {
                return this.hasTankTrayField;
            }
            set
            {
                this.hasTankTrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTankTraySpecified
        {
            get
            {
                return this.hasTankTrayFieldSpecified;
            }
            set
            {
                this.hasTankTrayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string lifespan
        {
            get
            {
                return this.lifespanField;
            }
            set
            {
                this.lifespanField = value;
            }
        }
    }
}