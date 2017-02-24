namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Cycling
    {

        private LengthUnit bicycleFrameSizeField;

        private LengthUnit bicycleWheelDiameterField;

        private string bicycleTireSizeField;

        private string numberOfSpeedsField;

        private string lightBulbTypeField;

        /// <remarks/>
        public LengthUnit bicycleFrameSize
        {
            get
            {
                return this.bicycleFrameSizeField;
            }
            set
            {
                this.bicycleFrameSizeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit bicycleWheelDiameter
        {
            get
            {
                return this.bicycleWheelDiameterField;
            }
            set
            {
                this.bicycleWheelDiameterField = value;
            }
        }

        /// <remarks/>
        public string bicycleTireSize
        {
            get
            {
                return this.bicycleTireSizeField;
            }
            set
            {
                this.bicycleTireSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfSpeeds
        {
            get
            {
                return this.numberOfSpeedsField;
            }
            set
            {
                this.numberOfSpeedsField = value;
            }
        }

        /// <remarks/>
        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }
    }
}