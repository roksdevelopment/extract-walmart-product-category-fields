namespace MarketHub.Market.Walmart.Entities.v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://walmart.com/content")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://walmart.com/content", IsNullable=false)]
    public partial class category {
    
        private object _itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Animal", typeof(Animal))]
        [System.Xml.Serialization.XmlElementAttribute("ArtAndCraftCategory", typeof(ArtAndCraftCategory))]
        [System.Xml.Serialization.XmlElementAttribute("Baby", typeof(Baby))]
        [System.Xml.Serialization.XmlElementAttribute("CarriersAndAccessoriesCategory", typeof(CarriersAndAccessoriesCategory))]
        [System.Xml.Serialization.XmlElementAttribute("ClothingCategory", typeof(ClothingCategory))]
        [System.Xml.Serialization.XmlElementAttribute("Electronics", typeof(Electronics))]
        [System.Xml.Serialization.XmlElementAttribute("FoodAndBeverageCategory", typeof(FoodAndBeverageCategory))]
        [System.Xml.Serialization.XmlElementAttribute("FootwearCategory", typeof(FootwearCategory))]
        [System.Xml.Serialization.XmlElementAttribute("FurnitureCategory", typeof(FurnitureCategory))]
        [System.Xml.Serialization.XmlElementAttribute("GardenAndPatioCategory", typeof(GardenAndPatioCategory))]
        [System.Xml.Serialization.XmlElementAttribute("HealthAndBeauty", typeof(HealthAndBeauty))]
        [System.Xml.Serialization.XmlElementAttribute("Home", typeof(Home))]
        [System.Xml.Serialization.XmlElementAttribute("JewelryCategory", typeof(JewelryCategory))]
        [System.Xml.Serialization.XmlElementAttribute("Media", typeof(Media))]
        [System.Xml.Serialization.XmlElementAttribute("MusicalInstrument", typeof(MusicalInstrument))]
        [System.Xml.Serialization.XmlElementAttribute("OccasionAndSeasonal", typeof(OccasionAndSeasonal))]
        [System.Xml.Serialization.XmlElementAttribute("OfficeCategory", typeof(OfficeCategory))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCategory", typeof(OtherCategory))]
        [System.Xml.Serialization.XmlElementAttribute("Photography", typeof(Photography))]
        [System.Xml.Serialization.XmlElementAttribute("SportAndRecreation", typeof(SportAndRecreation))]
        [System.Xml.Serialization.XmlElementAttribute("ToolsAndHardware", typeof(ToolsAndHardware))]
        [System.Xml.Serialization.XmlElementAttribute("ToysCategory", typeof(ToysCategory))]
        [System.Xml.Serialization.XmlElementAttribute("Vehicle", typeof(Vehicle))]
        [System.Xml.Serialization.XmlElementAttribute("WatchesCategory", typeof(WatchesCategory))]
        public object Item {
            get => _itemField;
            set => _itemField = value;
        }
    }
}