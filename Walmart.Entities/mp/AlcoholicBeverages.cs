namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class AlcoholicBeverages
    {

        private string alcoholContentByVolumeField;

        private string alcoholProofField;

        private string alcoholClassAndTypeField;

        private string neutralSpiritsColoringAndFlavoringField;

        private string whiskeyPercentageField;

        private bool isEstateBottledField;

        private bool isEstateBottledFieldSpecified;

        private string wineAppellationField;

        private string wineVarietalField;

        private bool containsSulfitesField;

        private bool containsSulfitesFieldSpecified;

        private bool isNonGrapeField;

        private bool isNonGrapeFieldSpecified;

        /// <remarks/>
        public string alcoholContentByVolume
        {
            get
            {
                return this.alcoholContentByVolumeField;
            }
            set
            {
                this.alcoholContentByVolumeField = value;
            }
        }

        /// <remarks/>
        public string alcoholProof
        {
            get
            {
                return this.alcoholProofField;
            }
            set
            {
                this.alcoholProofField = value;
            }
        }

        /// <remarks/>
        public string alcoholClassAndType
        {
            get
            {
                return this.alcoholClassAndTypeField;
            }
            set
            {
                this.alcoholClassAndTypeField = value;
            }
        }

        /// <remarks/>
        public string neutralSpiritsColoringAndFlavoring
        {
            get
            {
                return this.neutralSpiritsColoringAndFlavoringField;
            }
            set
            {
                this.neutralSpiritsColoringAndFlavoringField = value;
            }
        }

        /// <remarks/>
        public string whiskeyPercentage
        {
            get
            {
                return this.whiskeyPercentageField;
            }
            set
            {
                this.whiskeyPercentageField = value;
            }
        }

        /// <remarks/>
        public bool isEstateBottled
        {
            get
            {
                return this.isEstateBottledField;
            }
            set
            {
                this.isEstateBottledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEstateBottledSpecified
        {
            get
            {
                return this.isEstateBottledFieldSpecified;
            }
            set
            {
                this.isEstateBottledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string wineAppellation
        {
            get
            {
                return this.wineAppellationField;
            }
            set
            {
                this.wineAppellationField = value;
            }
        }

        /// <remarks/>
        public string wineVarietal
        {
            get
            {
                return this.wineVarietalField;
            }
            set
            {
                this.wineVarietalField = value;
            }
        }

        /// <remarks/>
        public bool containsSulfites
        {
            get
            {
                return this.containsSulfitesField;
            }
            set
            {
                this.containsSulfitesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool containsSulfitesSpecified
        {
            get
            {
                return this.containsSulfitesFieldSpecified;
            }
            set
            {
                this.containsSulfitesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isNonGrape
        {
            get
            {
                return this.isNonGrapeField;
            }
            set
            {
                this.isNonGrapeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNonGrapeSpecified
        {
            get
            {
                return this.isNonGrapeFieldSpecified;
            }
            set
            {
                this.isNonGrapeFieldSpecified = value;
            }
        }
    }
}