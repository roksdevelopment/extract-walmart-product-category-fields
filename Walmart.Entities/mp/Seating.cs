namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Seating
    {

        private LengthUnit seatBackHeightField;

        private string seatMaterialField;

        private LengthUnit seatHeightField;

        private string[] frameMaterialField;

        /// <remarks/>
        public LengthUnit seatBackHeight
        {
            get
            {
                return this.seatBackHeightField;
            }
            set
            {
                this.seatBackHeightField = value;
            }
        }

        /// <remarks/>
        public string seatMaterial
        {
            get
            {
                return this.seatMaterialField;
            }
            set
            {
                this.seatMaterialField = value;
            }
        }

        /// <remarks/>
        public LengthUnit seatHeight
        {
            get
            {
                return this.seatHeightField;
            }
            set
            {
                this.seatHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("frameMaterialValue", IsNullable = false)]
        public string[] frameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
            }
        }
    }
}