namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class TVsAndVideoDisplays
    {

        private string[] televisionTypeField;

        private bool hasTouchscreenField;

        private bool hasTouchscreenFieldSpecified;

        private string backlightTypeField;

        private FrequencyUnit refreshRateField;

        private TimeUnit responseTimeField;

        private string aspectRatioField;

        private string nativeResolutionField;

        private string maximumContrastRatioField;

        private inputsAndOutput[] inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private string resolutionField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("televisionTypeValue", IsNullable = false)]
        public string[] televisionType
        {
            get
            {
                return this.televisionTypeField;
            }
            set
            {
                this.televisionTypeField = value;
            }
        }

        /// <remarks/>
        public bool hasTouchscreen
        {
            get
            {
                return this.hasTouchscreenField;
            }
            set
            {
                this.hasTouchscreenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTouchscreenSpecified
        {
            get
            {
                return this.hasTouchscreenFieldSpecified;
            }
            set
            {
                this.hasTouchscreenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string backlightType
        {
            get
            {
                return this.backlightTypeField;
            }
            set
            {
                this.backlightTypeField = value;
            }
        }

        /// <remarks/>
        public FrequencyUnit refreshRate
        {
            get
            {
                return this.refreshRateField;
            }
            set
            {
                this.refreshRateField = value;
            }
        }

        /// <remarks/>
        public TimeUnit responseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }

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