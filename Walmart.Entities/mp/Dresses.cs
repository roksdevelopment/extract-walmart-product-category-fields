namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Dresses
    {

        private string skirtAndDressCutField;

        private string dressStyleField;

        private string sleeveStyleField;

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

        /// <remarks/>
        public string dressStyle
        {
            get
            {
                return this.dressStyleField;
            }
            set
            {
                this.dressStyleField = value;
            }
        }

        /// <remarks/>
        public string sleeveStyle
        {
            get
            {
                return this.sleeveStyleField;
            }
            set
            {
                this.sleeveStyleField = value;
            }
        }
    }
}