namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class VideoProjectors
    {

        private string aspectRatioField;

        private BrightnessUnit brightnessField;

        private string nativeResolutionField;

        private string maximumContrastRatioField;

        private string throwRatioField;

        private TimeUnit lampLifeField;

        private bool has3dCapabilitiesField;

        private bool has3dCapabilitiesFieldSpecified;

        private inputsAndOutput[] inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        public string aspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }

        /// <remarks/>
        public BrightnessUnit brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        /// <remarks/>
        public string nativeResolution
        {
            get
            {
                return this.nativeResolutionField;
            }
            set
            {
                this.nativeResolutionField = value;
            }
        }

        /// <remarks/>
        public string maximumContrastRatio
        {
            get
            {
                return this.maximumContrastRatioField;
            }
            set
            {
                this.maximumContrastRatioField = value;
            }
        }

        /// <remarks/>
        public string throwRatio
        {
            get
            {
                return this.throwRatioField;
            }
            set
            {
                this.throwRatioField = value;
            }
        }

        /// <remarks/>
        public TimeUnit lampLife
        {
            get
            {
                return this.lampLifeField;
            }
            set
            {
                this.lampLifeField = value;
            }
        }

        /// <remarks/>
        public bool has3dCapabilities
        {
            get
            {
                return this.has3dCapabilitiesField;
            }
            set
            {
                this.has3dCapabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool has3dCapabilitiesSpecified
        {
            get
            {
                return this.has3dCapabilitiesFieldSpecified;
            }
            set
            {
                this.has3dCapabilitiesFieldSpecified = value;
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
        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public string[] wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }
}