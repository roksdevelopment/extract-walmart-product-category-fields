namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://walmart.com/content")]
    public partial class HealthAndBeauty {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HealthAndBeautyElectronics", typeof(HealthAndBeautyElectronics))]
        [System.Xml.Serialization.XmlElementAttribute("MedicalAids", typeof(MedicalAids))]
        [System.Xml.Serialization.XmlElementAttribute("MedicineAndSupplements", typeof(MedicineAndSupplements))]
        [System.Xml.Serialization.XmlElementAttribute("Optical", typeof(Optical))]
        [System.Xml.Serialization.XmlElementAttribute("PersonalCare", typeof(PersonalCare))]
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