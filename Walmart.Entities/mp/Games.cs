namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Games
    {

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private NumberOfPlayer numberOfPlayersField;

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
        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public NumberOfPlayer numberOfPlayers
        {
            get
            {
                return this.numberOfPlayersField;
            }
            set
            {
                this.numberOfPlayersField = value;
            }
        }
    }
}