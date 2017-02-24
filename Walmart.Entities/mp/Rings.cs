namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Rings
    {

        private string[] ringStyleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ringStyleValue", IsNullable = false)]
        public string[] ringStyle
        {
            get
            {
                return this.ringStyleField;
            }
            set
            {
                this.ringStyleField = value;
            }
        }
    }
}