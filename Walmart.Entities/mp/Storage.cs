namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Storage
    {

        private string collectionField;

        private LengthUnit shelfDepthField;

        private string shelfStyleField;

        private string[] recommendedUsesField;

        private string drawerPositionField;

        private string drawerDimensionsField;

        private string numberOfDrawersField;

        private string numberOfShelvesField;

        private WeightUnit maximumWeightField;

        private string capacityField;

        /// <remarks/>
        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        /// <remarks/>
        public LengthUnit shelfDepth
        {
            get
            {
                return this.shelfDepthField;
            }
            set
            {
                this.shelfDepthField = value;
            }
        }

        /// <remarks/>
        public string shelfStyle
        {
            get
            {
                return this.shelfStyleField;
            }
            set
            {
                this.shelfStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public string[] recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        /// <remarks/>
        public string drawerPosition
        {
            get
            {
                return this.drawerPositionField;
            }
            set
            {
                this.drawerPositionField = value;
            }
        }

        /// <remarks/>
        public string drawerDimensions
        {
            get
            {
                return this.drawerDimensionsField;
            }
            set
            {
                this.drawerDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfDrawers
        {
            get
            {
                return this.numberOfDrawersField;
            }
            set
            {
                this.numberOfDrawersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfShelves
        {
            get
            {
                return this.numberOfShelvesField;
            }
            set
            {
                this.numberOfShelvesField = value;
            }
        }

        /// <remarks/>
        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        /// <remarks/>
        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }
    }
}