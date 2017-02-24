namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MPProduct
    {

        private string productNameField;

        private string longDescriptionField;

        private string shelfDescriptionField;

        private string shortDescriptionField;

        private MainImage mainImageField;

        private additionalAsset[] additionalAssetsField;

        private productIdentifier[] productIdentifiersField;

        private CurrencyUnit msrpField;

        private string unitsPerConsumerUnitField;

        private string[] featuresField;

        private certificationsAndClaim[] certificationsAndClaimsField;

        private LengthUnit assembledProductLengthField;

        private LengthUnit assembledProductWidthField;

        private LengthUnit assembledProductHeightField;

        private WeightUnit assembledProductWeightField;

        private string[] sportsLeagueField;

        private string productTaxCodeField;

        private string[] sportsTeamField;

        private string[] athleteField;

        private MPProductCountryOfOriginAssembly countryOfOriginAssemblyField;

        private bool countryOfOriginAssemblyFieldSpecified;

        private MPProductCountryOfOriginComponents countryOfOriginComponentsField;

        private bool countryOfOriginComponentsFieldSpecified;

        private bool autographedField;

        private bool autographedFieldSpecified;

        private string autographedByField;

        private bool hasBatteriesField;

        private bool hasBatteriesFieldSpecified;

        private batteryTypeAndQuantityValue[] batteryTypeAndQuantityField;

        private PPUUnit pricePerUnitQuantityField;

        private bool hasExpirationField;

        private bool hasExpirationFieldSpecified;

        private bool hasWarningsField;

        private bool hasWarningsFieldSpecified;

        private string warningTextField;

        private bool hasWarrantyField;

        private bool hasWarrantyFieldSpecified;

        private string warrantyURLField;

        private string warrantyTextField;

        private bool isProp65WarningRequiredField;

        private bool isProp65WarningRequiredFieldSpecified;

        private string[] smallPartsWarningsField;

        private bool isControlledSubstanceField;

        private bool isControlledSubstanceFieldSpecified;

        private string warrantyLengthField;

        private string prop65WarningTextField;

        private additionalProductAttribute[] additionalProductAttributesField;

        private object itemField;

        /// <remarks/>
        public string productName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        public string longDescription
        {
            get
            {
                return this.longDescriptionField;
            }
            set
            {
                this.longDescriptionField = value;
            }
        }

        /// <remarks/>
        public string shelfDescription
        {
            get
            {
                return this.shelfDescriptionField;
            }
            set
            {
                this.shelfDescriptionField = value;
            }
        }

        /// <remarks/>
        public string shortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        public MainImage mainImage
        {
            get
            {
                return this.mainImageField;
            }
            set
            {
                this.mainImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public additionalAsset[] additionalAssets
        {
            get
            {
                return this.additionalAssetsField;
            }
            set
            {
                this.additionalAssetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public productIdentifier[] productIdentifiers
        {
            get
            {
                return this.productIdentifiersField;
            }
            set
            {
                this.productIdentifiersField = value;
            }
        }

        /// <remarks/>
        public CurrencyUnit msrp
        {
            get
            {
                return this.msrpField;
            }
            set
            {
                this.msrpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string unitsPerConsumerUnit
        {
            get
            {
                return this.unitsPerConsumerUnitField;
            }
            set
            {
                this.unitsPerConsumerUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("feature", IsNullable = false)]
        public string[] features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public certificationsAndClaim[] certificationsAndClaims
        {
            get
            {
                return this.certificationsAndClaimsField;
            }
            set
            {
                this.certificationsAndClaimsField = value;
            }
        }

        /// <remarks/>
        public LengthUnit assembledProductLength
        {
            get
            {
                return this.assembledProductLengthField;
            }
            set
            {
                this.assembledProductLengthField = value;
            }
        }

        /// <remarks/>
        public LengthUnit assembledProductWidth
        {
            get
            {
                return this.assembledProductWidthField;
            }
            set
            {
                this.assembledProductWidthField = value;
            }
        }

        /// <remarks/>
        public LengthUnit assembledProductHeight
        {
            get
            {
                return this.assembledProductHeightField;
            }
            set
            {
                this.assembledProductHeightField = value;
            }
        }

        /// <remarks/>
        public WeightUnit assembledProductWeight
        {
            get
            {
                return this.assembledProductWeightField;
            }
            set
            {
                this.assembledProductWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sportsLeagueValue", IsNullable = false)]
        public string[] sportsLeague
        {
            get
            {
                return this.sportsLeagueField;
            }
            set
            {
                this.sportsLeagueField = value;
            }
        }

        /// <remarks/>
        public string productTaxCode
        {
            get
            {
                return this.productTaxCodeField;
            }
            set
            {
                this.productTaxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sportsTeamValue", IsNullable = false)]
        public string[] sportsTeam
        {
            get
            {
                return this.sportsTeamField;
            }
            set
            {
                this.sportsTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("athleteValue", IsNullable = false)]
        public string[] athlete
        {
            get
            {
                return this.athleteField;
            }
            set
            {
                this.athleteField = value;
            }
        }

        /// <remarks/>
        public MPProductCountryOfOriginAssembly countryOfOriginAssembly
        {
            get
            {
                return this.countryOfOriginAssemblyField;
            }
            set
            {
                this.countryOfOriginAssemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countryOfOriginAssemblySpecified
        {
            get
            {
                return this.countryOfOriginAssemblyFieldSpecified;
            }
            set
            {
                this.countryOfOriginAssemblyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public MPProductCountryOfOriginComponents countryOfOriginComponents
        {
            get
            {
                return this.countryOfOriginComponentsField;
            }
            set
            {
                this.countryOfOriginComponentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countryOfOriginComponentsSpecified
        {
            get
            {
                return this.countryOfOriginComponentsFieldSpecified;
            }
            set
            {
                this.countryOfOriginComponentsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool autographed
        {
            get
            {
                return this.autographedField;
            }
            set
            {
                this.autographedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autographedSpecified
        {
            get
            {
                return this.autographedFieldSpecified;
            }
            set
            {
                this.autographedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string autographedBy
        {
            get
            {
                return this.autographedByField;
            }
            set
            {
                this.autographedByField = value;
            }
        }

        /// <remarks/>
        public bool hasBatteries
        {
            get
            {
                return this.hasBatteriesField;
            }
            set
            {
                this.hasBatteriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBatteriesSpecified
        {
            get
            {
                return this.hasBatteriesFieldSpecified;
            }
            set
            {
                this.hasBatteriesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public batteryTypeAndQuantityValue[] batteryTypeAndQuantity
        {
            get
            {
                return this.batteryTypeAndQuantityField;
            }
            set
            {
                this.batteryTypeAndQuantityField = value;
            }
        }

        /// <remarks/>
        public PPUUnit pricePerUnitQuantity
        {
            get
            {
                return this.pricePerUnitQuantityField;
            }
            set
            {
                this.pricePerUnitQuantityField = value;
            }
        }

        /// <remarks/>
        public bool hasExpiration
        {
            get
            {
                return this.hasExpirationField;
            }
            set
            {
                this.hasExpirationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasExpirationSpecified
        {
            get
            {
                return this.hasExpirationFieldSpecified;
            }
            set
            {
                this.hasExpirationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasWarnings
        {
            get
            {
                return this.hasWarningsField;
            }
            set
            {
                this.hasWarningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWarningsSpecified
        {
            get
            {
                return this.hasWarningsFieldSpecified;
            }
            set
            {
                this.hasWarningsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string warningText
        {
            get
            {
                return this.warningTextField;
            }
            set
            {
                this.warningTextField = value;
            }
        }

        /// <remarks/>
        public bool hasWarranty
        {
            get
            {
                return this.hasWarrantyField;
            }
            set
            {
                this.hasWarrantyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWarrantySpecified
        {
            get
            {
                return this.hasWarrantyFieldSpecified;
            }
            set
            {
                this.hasWarrantyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string warrantyURL
        {
            get
            {
                return this.warrantyURLField;
            }
            set
            {
                this.warrantyURLField = value;
            }
        }

        /// <remarks/>
        public string warrantyText
        {
            get
            {
                return this.warrantyTextField;
            }
            set
            {
                this.warrantyTextField = value;
            }
        }

        /// <remarks/>
        public bool isProp65WarningRequired
        {
            get
            {
                return this.isProp65WarningRequiredField;
            }
            set
            {
                this.isProp65WarningRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isProp65WarningRequiredSpecified
        {
            get
            {
                return this.isProp65WarningRequiredFieldSpecified;
            }
            set
            {
                this.isProp65WarningRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("smallPartsWarning", DataType = "integer", IsNullable = false)]
        public string[] smallPartsWarnings
        {
            get
            {
                return this.smallPartsWarningsField;
            }
            set
            {
                this.smallPartsWarningsField = value;
            }
        }

        /// <remarks/>
        public bool isControlledSubstance
        {
            get
            {
                return this.isControlledSubstanceField;
            }
            set
            {
                this.isControlledSubstanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isControlledSubstanceSpecified
        {
            get
            {
                return this.isControlledSubstanceFieldSpecified;
            }
            set
            {
                this.isControlledSubstanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string warrantyLength
        {
            get
            {
                return this.warrantyLengthField;
            }
            set
            {
                this.warrantyLengthField = value;
            }
        }

        /// <remarks/>
        public string prop65WarningText
        {
            get
            {
                return this.prop65WarningTextField;
            }
            set
            {
                this.prop65WarningTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public additionalProductAttribute[] additionalProductAttributes
        {
            get
            {
                return this.additionalProductAttributesField;
            }
            set
            {
                this.additionalProductAttributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Animal", typeof(Animal))]
        [System.Xml.Serialization.XmlElementAttribute("ArtAndCraft", typeof(ArtAndCraft))]
        [System.Xml.Serialization.XmlElementAttribute("Baby", typeof(Baby))]
        [System.Xml.Serialization.XmlElementAttribute("CarriersAndAccessories", typeof(CarriersAndAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("Clothing", typeof(Clothing))]
        [System.Xml.Serialization.XmlElementAttribute("Electronics", typeof(Electronics))]
        [System.Xml.Serialization.XmlElementAttribute("FoodAndBeverage", typeof(FoodAndBeverage))]
        [System.Xml.Serialization.XmlElementAttribute("Footwear", typeof(Footwear))]
        [System.Xml.Serialization.XmlElementAttribute("Furniture", typeof(Furniture))]
        [System.Xml.Serialization.XmlElementAttribute("GardenAndPatio", typeof(GardenAndPatio))]
        [System.Xml.Serialization.XmlElementAttribute("HealthAndBeauty", typeof(HealthAndBeauty))]
        [System.Xml.Serialization.XmlElementAttribute("Home", typeof(Home))]
        [System.Xml.Serialization.XmlElementAttribute("Jewelry", typeof(Jewelry))]
        [System.Xml.Serialization.XmlElementAttribute("Media", typeof(Media))]
        [System.Xml.Serialization.XmlElementAttribute("MusicalInstrument", typeof(MusicalInstrument))]
        [System.Xml.Serialization.XmlElementAttribute("OccasionAndSeasonal", typeof(OccasionAndSeasonal))]
        [System.Xml.Serialization.XmlElementAttribute("Office", typeof(Office))]
        [System.Xml.Serialization.XmlElementAttribute("Other", typeof(Other))]
        [System.Xml.Serialization.XmlElementAttribute("Photography", typeof(Photography))]
        [System.Xml.Serialization.XmlElementAttribute("SportAndRecreation", typeof(SportAndRecreation))]
        [System.Xml.Serialization.XmlElementAttribute("ToolsAndHardware", typeof(ToolsAndHardware))]
        [System.Xml.Serialization.XmlElementAttribute("Toy", typeof(Toy))]
        [System.Xml.Serialization.XmlElementAttribute("Vehicle", typeof(Vehicle))]
        [System.Xml.Serialization.XmlElementAttribute("Watches", typeof(Watches))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}