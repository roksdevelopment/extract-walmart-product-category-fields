namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BuildingSupply
    {

        private string homeDecorStyleField;

        private BuildingSupplyAcRating acRatingField;

        private bool acRatingFieldSpecified;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isBiodegradableField;

        private bool isBiodegradableFieldSpecified;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private string carpetStyleField;

        private string[] patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private bool isCombustibleField;

        private bool isCombustibleFieldSpecified;

        private string[] compatibleSurfacesField;

        private AreaUnit coverageAreaField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private TimeUnit dryTimeField;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private bool isFastSettingField;

        private bool isFastSettingFieldSpecified;

        private string finenessField;

        private bool isFlammableField;

        private bool isFlammableFieldSpecified;

        private string gradeField;

        private bool hasLowEmissivityField;

        private bool hasLowEmissivityFieldSpecified;

        private bool isMadeFromReclaimedMaterialsField;

        private bool isMadeFromReclaimedMaterialsFieldSpecified;

        private bool isMadeFromSustainableMaterialsField;

        private bool isMadeFromSustainableMaterialsFieldSpecified;

        private bool isMoldResistantField;

        private bool isMoldResistantFieldSpecified;

        private bool isOdorlessField;

        private bool isOdorlessFieldSpecified;

        private string paintFinishField;

        private string peiRatingField;

        private LengthUnit pileHeightField;

        private bool isPrefinishedField;

        private bool isPrefinishedFieldSpecified;

        private bool isReadyToUseField;

        private bool isReadyToUseFieldSpecified;

        private string[] recommendedSurfacesField;

        private LengthUnit rollLengthField;

        private PressureUnit snowLoadRatingField;

        private PercentageUnit vocLevelField;

        private bool isWaterSolubleField;

        private bool isWaterSolubleFieldSpecified;

        private string subjectField;

        private activeIngredient[] activeIngredientsField;

        private string[] inactiveIngredientsField;

        private string formField;

        private bool hasCeeCertificationField;

        private bool hasCeeCertificationFieldSpecified;

        private BuildingSupplyCeeTier ceeTierField;

        private bool ceeTierFieldSpecified;

        /// <remarks/>
        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        /// <remarks/>
        public BuildingSupplyAcRating acRating
        {
            get
            {
                return this.acRatingField;
            }
            set
            {
                this.acRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool acRatingSpecified
        {
            get
            {
                return this.acRatingFieldSpecified;
            }
            set
            {
                this.acRatingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        /// <remarks/>
        public bool isBiodegradable
        {
            get
            {
                return this.isBiodegradableField;
            }
            set
            {
                this.isBiodegradableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBiodegradableSpecified
        {
            get
            {
                return this.isBiodegradableFieldSpecified;
            }
            set
            {
                this.isBiodegradableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string carpetStyle
        {
            get
            {
                return this.carpetStyleField;
            }
            set
            {
                this.carpetStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public string[] pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        /// <remarks/>
        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        /// <remarks/>
        public bool isCombustible
        {
            get
            {
                return this.isCombustibleField;
            }
            set
            {
                this.isCombustibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCombustibleSpecified
        {
            get
            {
                return this.isCombustibleFieldSpecified;
            }
            set
            {
                this.isCombustibleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleSurface", IsNullable = false)]
        public string[] compatibleSurfaces
        {
            get
            {
                return this.compatibleSurfacesField;
            }
            set
            {
                this.compatibleSurfacesField = value;
            }
        }

        /// <remarks/>
        public AreaUnit coverageArea
        {
            get
            {
                return this.coverageAreaField;
            }
            set
            {
                this.coverageAreaField = value;
            }
        }

        /// <remarks/>
        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeUnit dryTime
        {
            get
            {
                return this.dryTimeField;
            }
            set
            {
                this.dryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public recycledMaterialContentValue[] recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        /// <remarks/>
        public bool isFastSetting
        {
            get
            {
                return this.isFastSettingField;
            }
            set
            {
                this.isFastSettingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFastSettingSpecified
        {
            get
            {
                return this.isFastSettingFieldSpecified;
            }
            set
            {
                this.isFastSettingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        /// <remarks/>
        public bool isFlammable
        {
            get
            {
                return this.isFlammableField;
            }
            set
            {
                this.isFlammableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFlammableSpecified
        {
            get
            {
                return this.isFlammableFieldSpecified;
            }
            set
            {
                this.isFlammableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string grade
        {
            get
            {
                return this.gradeField;
            }
            set
            {
                this.gradeField = value;
            }
        }

        /// <remarks/>
        public bool hasLowEmissivity
        {
            get
            {
                return this.hasLowEmissivityField;
            }
            set
            {
                this.hasLowEmissivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasLowEmissivitySpecified
        {
            get
            {
                return this.hasLowEmissivityFieldSpecified;
            }
            set
            {
                this.hasLowEmissivityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isMadeFromReclaimedMaterials
        {
            get
            {
                return this.isMadeFromReclaimedMaterialsField;
            }
            set
            {
                this.isMadeFromReclaimedMaterialsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromReclaimedMaterialsSpecified
        {
            get
            {
                return this.isMadeFromReclaimedMaterialsFieldSpecified;
            }
            set
            {
                this.isMadeFromReclaimedMaterialsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isMadeFromSustainableMaterials
        {
            get
            {
                return this.isMadeFromSustainableMaterialsField;
            }
            set
            {
                this.isMadeFromSustainableMaterialsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromSustainableMaterialsSpecified
        {
            get
            {
                return this.isMadeFromSustainableMaterialsFieldSpecified;
            }
            set
            {
                this.isMadeFromSustainableMaterialsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isMoldResistant
        {
            get
            {
                return this.isMoldResistantField;
            }
            set
            {
                this.isMoldResistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMoldResistantSpecified
        {
            get
            {
                return this.isMoldResistantFieldSpecified;
            }
            set
            {
                this.isMoldResistantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isOdorless
        {
            get
            {
                return this.isOdorlessField;
            }
            set
            {
                this.isOdorlessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOdorlessSpecified
        {
            get
            {
                return this.isOdorlessFieldSpecified;
            }
            set
            {
                this.isOdorlessFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string paintFinish
        {
            get
            {
                return this.paintFinishField;
            }
            set
            {
                this.paintFinishField = value;
            }
        }

        /// <remarks/>
        public string peiRating
        {
            get
            {
                return this.peiRatingField;
            }
            set
            {
                this.peiRatingField = value;
            }
        }

        /// <remarks/>
        public LengthUnit pileHeight
        {
            get
            {
                return this.pileHeightField;
            }
            set
            {
                this.pileHeightField = value;
            }
        }

        /// <remarks/>
        public bool isPrefinished
        {
            get
            {
                return this.isPrefinishedField;
            }
            set
            {
                this.isPrefinishedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrefinishedSpecified
        {
            get
            {
                return this.isPrefinishedFieldSpecified;
            }
            set
            {
                this.isPrefinishedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isReadyToUse
        {
            get
            {
                return this.isReadyToUseField;
            }
            set
            {
                this.isReadyToUseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReadyToUseSpecified
        {
            get
            {
                return this.isReadyToUseFieldSpecified;
            }
            set
            {
                this.isReadyToUseFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedSurface", IsNullable = false)]
        public string[] recommendedSurfaces
        {
            get
            {
                return this.recommendedSurfacesField;
            }
            set
            {
                this.recommendedSurfacesField = value;
            }
        }

        /// <remarks/>
        public LengthUnit rollLength
        {
            get
            {
                return this.rollLengthField;
            }
            set
            {
                this.rollLengthField = value;
            }
        }

        /// <remarks/>
        public PressureUnit snowLoadRating
        {
            get
            {
                return this.snowLoadRatingField;
            }
            set
            {
                this.snowLoadRatingField = value;
            }
        }

        /// <remarks/>
        public PercentageUnit vocLevel
        {
            get
            {
                return this.vocLevelField;
            }
            set
            {
                this.vocLevelField = value;
            }
        }

        /// <remarks/>
        public bool isWaterSoluble
        {
            get
            {
                return this.isWaterSolubleField;
            }
            set
            {
                this.isWaterSolubleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterSolubleSpecified
        {
            get
            {
                return this.isWaterSolubleFieldSpecified;
            }
            set
            {
                this.isWaterSolubleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public activeIngredient[] activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public string[] inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
            }
        }

        /// <remarks/>
        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        public bool hasCeeCertification
        {
            get
            {
                return this.hasCeeCertificationField;
            }
            set
            {
                this.hasCeeCertificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCeeCertificationSpecified
        {
            get
            {
                return this.hasCeeCertificationFieldSpecified;
            }
            set
            {
                this.hasCeeCertificationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BuildingSupplyCeeTier ceeTier
        {
            get
            {
                return this.ceeTierField;
            }
            set
            {
                this.ceeTierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ceeTierSpecified
        {
            get
            {
                return this.ceeTierFieldSpecified;
            }
            set
            {
                this.ceeTierFieldSpecified = value;
            }
        }
    }
}