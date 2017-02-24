namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Skirts
    {

        private LengthUnit waistSizeField;

        private string skirtAndDressCutField;

        /// <remarks/>
        public LengthUnit waistSize
        {
            get
            {
                return this.waistSizeField;
            }
            set
            {
                this.waistSizeField = value;
            }
        }

        /// <remarks/>
        public string skirtAndDressCut
        {
            get
            {
                return this.skirtAndDressCutField;
            }
            set
            {
                this.skirtAndDressCutField = value;
            }
        }
    }
}