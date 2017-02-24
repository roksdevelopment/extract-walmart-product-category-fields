namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Strollers
    {

        private string seatingCapacityField;

        private string strollerTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        /// <remarks/>
        public string strollerType
        {
            get
            {
                return this.strollerTypeField;
            }
            set
            {
                this.strollerTypeField = value;
            }
        }
    }
}