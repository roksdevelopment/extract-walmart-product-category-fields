namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MusicalInstruments
    {

        private string finishField;

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private string[] ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string powerTypeField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private string[] recommendedUsesField;

        private string[] recommendedLocationsField;

        private string audioPowerOutputField;

        private bool isCollectibleField;

        private bool isCollectibleFieldSpecified;

        private string musicalInstrumentFamilyField;

        private bool isAcousticField;

        private bool isAcousticFieldSpecified;

        private bool isElectricField;

        private bool isElectricFieldSpecified;

        private bool isFrettedField;

        private bool isFrettedFieldSpecified;

        private string[] instrumentField;

        private string shapeField;

        private inputsAndOutput[] inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        /// <remarks/>
        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
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
        public bool isCollectible
        {
            get
            {
                return this.isCollectibleField;
            }
            set
            {
                this.isCollectibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectibleSpecified
        {
            get
            {
                return this.isCollectibleFieldSpecified;
            }
            set
            {
                this.isCollectibleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string musicalInstrumentFamily
        {
            get
            {
                return this.musicalInstrumentFamilyField;
            }
            set
            {
                this.musicalInstrumentFamilyField = value;
            }
        }

        /// <remarks/>
        public bool isAcoustic
        {
            get
            {
                return this.isAcousticField;
            }
            set
            {
                this.isAcousticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAcousticSpecified
        {
            get
            {
                return this.isAcousticFieldSpecified;
            }
            set
            {
                this.isAcousticFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isElectric
        {
            get
            {
                return this.isElectricField;
            }
            set
            {
                this.isElectricField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isElectricSpecified
        {
            get
            {
                return this.isElectricFieldSpecified;
            }
            set
            {
                this.isElectricFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isFretted
        {
            get
            {
                return this.isFrettedField;
            }
            set
            {
                this.isFrettedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFrettedSpecified
        {
            get
            {
                return this.isFrettedFieldSpecified;
            }
            set
            {
                this.isFrettedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("instrumentValue", IsNullable = false)]
        public string[] instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
            }
        }

        /// <remarks/>
        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public inputsAndOutput[] inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        /// <remarks/>
        public bool hasIntegratedSpeakers
        {
            get
            {
                return this.hasIntegratedSpeakersField;
            }
            set
            {
                this.hasIntegratedSpeakersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasIntegratedSpeakersSpecified
        {
            get
            {
                return this.hasIntegratedSpeakersFieldSpecified;
            }
            set
            {
                this.hasIntegratedSpeakersFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        /// <remarks/>
        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
            }
        }
    }
}