namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BabyFurniture
    {

        private string collectionField;

        private string finishField;

        private string homeDecorStyleField;

        private string[] materialField;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private string mattressFirmnessField;

        private string[] fillMaterialField;

        private string bedSizeField;

        private string shapeField;

        /// <remarks/>
        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

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
        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
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
        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
        {
            get
            {
                return this.isAssemblyRequiredFieldSpecified;
            }
            set
            {
                this.isAssemblyRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string assemblyInstructions
        {
            get
            {
                return this.assemblyInstructionsField;
            }
            set
            {
                this.assemblyInstructionsField = value;
            }
        }

        /// <remarks/>
        public string mattressFirmness
        {
            get
            {
                return this.mattressFirmnessField;
            }
            set
            {
                this.mattressFirmnessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public string[] fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        /// <remarks/>
        public string bedSize
        {
            get
            {
                return this.bedSizeField;
            }
            set
            {
                this.bedSizeField = value;
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