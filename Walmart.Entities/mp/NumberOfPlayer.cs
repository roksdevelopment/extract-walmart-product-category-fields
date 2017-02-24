namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class NumberOfPlayer
    {

        private string minimumNumberOfPlayersField;

        private string maximumNumberOfPlayersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string minimumNumberOfPlayers
        {
            get
            {
                return this.minimumNumberOfPlayersField;
            }
            set
            {
                this.minimumNumberOfPlayersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string maximumNumberOfPlayers
        {
            get
            {
                return this.maximumNumberOfPlayersField;
            }
            set
            {
                this.maximumNumberOfPlayersField = value;
            }
        }
    }
}