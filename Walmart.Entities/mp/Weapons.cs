namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Weapons
    {

        private decimal shotgunGaugeField;

        private bool shotgunGaugeFieldSpecified;

        private SpeedUnit velocityField;

        private string firearmActionField;

        private LengthUnit caliberField;

        private string ammunitionTypeField;

        private string firearmChamberLengthField;

        /// <remarks/>
        public decimal shotgunGauge
        {
            get
            {
                return this.shotgunGaugeField;
            }
            set
            {
                this.shotgunGaugeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shotgunGaugeSpecified
        {
            get
            {
                return this.shotgunGaugeFieldSpecified;
            }
            set
            {
                this.shotgunGaugeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SpeedUnit velocity
        {
            get
            {
                return this.velocityField;
            }
            set
            {
                this.velocityField = value;
            }
        }

        /// <remarks/>
        public string firearmAction
        {
            get
            {
                return this.firearmActionField;
            }
            set
            {
                this.firearmActionField = value;
            }
        }

        /// <remarks/>
        public LengthUnit caliber
        {
            get
            {
                return this.caliberField;
            }
            set
            {
                this.caliberField = value;
            }
        }

        /// <remarks/>
        public string ammunitionType
        {
            get
            {
                return this.ammunitionTypeField;
            }
            set
            {
                this.ammunitionTypeField = value;
            }
        }

        /// <remarks/>
        public string firearmChamberLength
        {
            get
            {
                return this.firearmChamberLengthField;
            }
            set
            {
                this.firearmChamberLengthField = value;
            }
        }
    }
}