namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class PantsAndShorts
    {

        private PantSize pantSizeField;

        private string pantRiseField;

        private string pantStyleField;

        private string pantPanelStyleField;

        /// <remarks/>
        public PantSize pantSize
        {
            get
            {
                return this.pantSizeField;
            }
            set
            {
                this.pantSizeField = value;
            }
        }

        /// <remarks/>
        public string pantRise
        {
            get
            {
                return this.pantRiseField;
            }
            set
            {
                this.pantRiseField = value;
            }
        }

        /// <remarks/>
        public string pantStyle
        {
            get
            {
                return this.pantStyleField;
            }
            set
            {
                this.pantStyleField = value;
            }
        }

        /// <remarks/>
        public string pantPanelStyle
        {
            get
            {
                return this.pantPanelStyleField;
            }
            set
            {
                this.pantPanelStyleField = value;
            }
        }
    }
}