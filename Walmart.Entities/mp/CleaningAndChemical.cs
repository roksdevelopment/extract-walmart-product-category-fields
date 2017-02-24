namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class CleaningAndChemical
    {

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private bool isBiodegradableField;

        private bool isBiodegradableFieldSpecified;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private bool isCombustibleField;

        private bool isCombustibleFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private bool isFlammableField;

        private bool isFlammableFieldSpecified;

        private string ingredientsField;

        private LengthUnit handleLengthField;

        private VolumeUnit fluidOuncesField;

        private string scentField;

        private activeIngredient[] activeIngredientsField;

        private string[] inactiveIngredientsField;

        private string formField;

        private string instructionsField;

        /// <remarks/>
        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
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
        public string ingredients
        {
            get
            {
                return this.ingredientsField;
            }
            set
            {
                this.ingredientsField = value;
            }
        }

        /// <remarks/>
        public LengthUnit handleLength
        {
            get
            {
                return this.handleLengthField;
            }
            set
            {
                this.handleLengthField = value;
            }
        }

        /// <remarks/>
        public VolumeUnit fluidOunces
        {
            get
            {
                return this.fluidOuncesField;
            }
            set
            {
                this.fluidOuncesField = value;
            }
        }

        /// <remarks/>
        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
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
        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }
    }
}