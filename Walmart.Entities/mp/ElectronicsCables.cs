namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class ElectronicsCables
    {

        private string connectorFinishField;

        private LengthUnit cableLengthField;

        private string numberOfTwistedPairsPerCableField;

        private string[] compatibleDevicesField;

        /// <remarks/>
        public string connectorFinish
        {
            get
            {
                return this.connectorFinishField;
            }
            set
            {
                this.connectorFinishField = value;
            }
        }

        /// <remarks/>
        public LengthUnit cableLength
        {
            get
            {
                return this.cableLengthField;
            }
            set
            {
                this.cableLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfTwistedPairsPerCable
        {
            get
            {
                return this.numberOfTwistedPairsPerCableField;
            }
            set
            {
                this.numberOfTwistedPairsPerCableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public string[] compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }
    }
}