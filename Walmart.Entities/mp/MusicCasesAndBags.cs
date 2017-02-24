namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class MusicCasesAndBags
    {

        private fabricContentValue[] fabricContentField;

        private string[] fabricCareInstructionsField;

        private bool hardOrSoftCaseField;

        private bool hardOrSoftCaseFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private string[] instrumentField;

        private string shapeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public fabricContentValue[] fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public string[] fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        /// <remarks/>
        public bool hardOrSoftCase
        {
            get
            {
                return this.hardOrSoftCaseField;
            }
            set
            {
                this.hardOrSoftCaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hardOrSoftCaseSpecified
        {
            get
            {
                return this.hardOrSoftCaseFieldSpecified;
            }
            set
            {
                this.hardOrSoftCaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
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
    }
}