namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class batteryTypeAndQuantityValue
    {

        private batteryTypeAndQuantityValueBatteryTechnologyType batteryTechnologyTypeField;

        private bool batteryTechnologyTypeFieldSpecified;

        private string numberOfBatteriesField;

        /// <remarks/>
        public batteryTypeAndQuantityValueBatteryTechnologyType batteryTechnologyType
        {
            get
            {
                return this.batteryTechnologyTypeField;
            }
            set
            {
                this.batteryTechnologyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteryTechnologyTypeSpecified
        {
            get
            {
                return this.batteryTechnologyTypeFieldSpecified;
            }
            set
            {
                this.batteryTechnologyTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfBatteries
        {
            get
            {
                return this.numberOfBatteriesField;
            }
            set
            {
                this.numberOfBatteriesField = value;
            }
        }
    }
}