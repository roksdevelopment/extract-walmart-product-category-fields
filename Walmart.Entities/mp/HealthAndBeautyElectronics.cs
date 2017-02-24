namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class HealthAndBeautyElectronics
    {

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string[] connectionsField;

        private bool isCordlessField;

        private bool isCordlessFieldSpecified;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

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
        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
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
    }
}