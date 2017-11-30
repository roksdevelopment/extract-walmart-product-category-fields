namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class Vehicle {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LandVehicles", typeof(LandVehicles))]
        [System.Xml.Serialization.XmlElementAttribute("Tires", typeof(Tires))]
        [System.Xml.Serialization.XmlElementAttribute("VehicleOther", typeof(VehicleOther))]
        [System.Xml.Serialization.XmlElementAttribute("VehiclePartsAndAccessories", typeof(VehiclePartsAndAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("Watercraft", typeof(Watercraft))]
        [System.Xml.Serialization.XmlElementAttribute("WheelsAndWheelComponents", typeof(WheelsAndWheelComponents))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}