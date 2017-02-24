namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class HomeDecor
    {

        private string[] colorField;

        private string rugSizeField;

        private string clockNumberTypeField;

        private string curtainPanelStyleField;

        private string[] fillMaterialField;

        private string scentField;

        private string threadCountField;

        private string displayTechnologyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public string[] color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public string rugSize
        {
            get
            {
                return this.rugSizeField;
            }
            set
            {
                this.rugSizeField = value;
            }
        }

        /// <remarks/>
        public string clockNumberType
        {
            get
            {
                return this.clockNumberTypeField;
            }
            set
            {
                this.clockNumberTypeField = value;
            }
        }

        /// <remarks/>
        public string curtainPanelStyle
        {
            get
            {
                return this.curtainPanelStyleField;
            }
            set
            {
                this.curtainPanelStyleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string threadCount
        {
            get
            {
                return this.threadCountField;
            }
            set
            {
                this.threadCountField = value;
            }
        }

        /// <remarks/>
        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }
    }
}