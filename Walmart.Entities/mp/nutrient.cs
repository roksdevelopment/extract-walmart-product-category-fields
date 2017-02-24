namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class nutrient
    {

        private string nutrientNameField;

        private decimal nutrientAmountField;

        private bool nutrientAmountFieldSpecified;

        private decimal nutrientPercentageDailyValueField;

        private bool nutrientPercentageDailyValueFieldSpecified;

        /// <remarks/>
        public string nutrientName
        {
            get
            {
                return this.nutrientNameField;
            }
            set
            {
                this.nutrientNameField = value;
            }
        }

        /// <remarks/>
        public decimal nutrientAmount
        {
            get
            {
                return this.nutrientAmountField;
            }
            set
            {
                this.nutrientAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nutrientAmountSpecified
        {
            get
            {
                return this.nutrientAmountFieldSpecified;
            }
            set
            {
                this.nutrientAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal nutrientPercentageDailyValue
        {
            get
            {
                return this.nutrientPercentageDailyValueField;
            }
            set
            {
                this.nutrientPercentageDailyValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nutrientPercentageDailyValueSpecified
        {
            get
            {
                return this.nutrientPercentageDailyValueFieldSpecified;
            }
            set
            {
                this.nutrientPercentageDailyValueFieldSpecified = value;
            }
        }
    }
}