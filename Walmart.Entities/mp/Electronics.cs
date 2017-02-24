namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Electronics
    {

        private swatchImage[] swatchImagesField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isEnergyGuideLabelRequiredField;

        private bool isEnergyGuideLabelRequiredFieldSpecified;

        private string energyGuideLabelField;

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private string[] colorField;

        private string[] ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private string[] connectionsField;

        private string[] materialField;

        private string numberOfPiecesField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isCordlessField;

        private bool isCordlessFieldSpecified;

        private string[] recommendedUsesField;

        private string[] recommendedLocationsField;

        private string audioPowerOutputField;

        private PowerUnit peakAudioPowerCapacityField;

        private string[] audioFeaturesField;

        private string numberOfChannelsField;

        private string resolutionField;

        private string platformField;

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public swatchImage[] swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public string[] variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        /// <remarks/>
        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        /// <remarks/>
        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isEnergyGuideLabelRequired
        {
            get
            {
                return this.isEnergyGuideLabelRequiredField;
            }
            set
            {
                this.isEnergyGuideLabelRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyGuideLabelRequiredSpecified
        {
            get
            {
                return this.isEnergyGuideLabelRequiredFieldSpecified;
            }
            set
            {
                this.isEnergyGuideLabelRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string energyGuideLabel
        {
            get
            {
                return this.energyGuideLabelField;
            }
            set
            {
                this.energyGuideLabelField = value;
            }
        }

        /// <remarks/>
        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }

        /// <remarks/>
        public string manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        /// <remarks/>
        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public string[] color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public string[] ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public string[] connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public string[] material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPieces
        {
            get
            {
                return this.numberOfPiecesField;
            }
            set
            {
                this.numberOfPiecesField = value;
            }
        }

        /// <remarks/>
        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isCordless
        {
            get
            {
                return this.isCordlessField;
            }
            set
            {
                this.isCordlessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCordlessSpecified
        {
            get
            {
                return this.isCordlessFieldSpecified;
            }
            set
            {
                this.isCordlessFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public string[] recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        /// <remarks/>
        public string audioPowerOutput
        {
            get
            {
                return this.audioPowerOutputField;
            }
            set
            {
                this.audioPowerOutputField = value;
            }
        }

        /// <remarks/>
        public PowerUnit peakAudioPowerCapacity
        {
            get
            {
                return this.peakAudioPowerCapacityField;
            }
            set
            {
                this.peakAudioPowerCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("audioFeature", IsNullable = false)]
        public string[] audioFeatures
        {
            get
            {
                return this.audioFeaturesField;
            }
            set
            {
                this.audioFeaturesField = value;
            }
        }

        /// <remarks/>
        public string numberOfChannels
        {
            get
            {
                return this.numberOfChannelsField;
            }
            set
            {
                this.numberOfChannelsField = value;
            }
        }

        /// <remarks/>
        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        /// <remarks/>
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CellPhones", typeof(CellPhones))]
        [System.Xml.Serialization.XmlElementAttribute("ComputerComponents", typeof(ComputerComponents))]
        [System.Xml.Serialization.XmlElementAttribute("Computers", typeof(Computers))]
        [System.Xml.Serialization.XmlElementAttribute("ElectronicsAccessories", typeof(ElectronicsAccessories))]
        [System.Xml.Serialization.XmlElementAttribute("ElectronicsCables", typeof(ElectronicsCables))]
        [System.Xml.Serialization.XmlElementAttribute("PrintersScannersAndImaging", typeof(PrintersScannersAndImaging))]
        [System.Xml.Serialization.XmlElementAttribute("Software", typeof(Software))]
        [System.Xml.Serialization.XmlElementAttribute("TVsAndVideoDisplays", typeof(TVsAndVideoDisplays))]
        [System.Xml.Serialization.XmlElementAttribute("VideoGames", typeof(VideoGames))]
        [System.Xml.Serialization.XmlElementAttribute("VideoProjectors", typeof(VideoProjectors))]
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