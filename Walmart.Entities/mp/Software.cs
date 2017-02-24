namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Software
    {

        private string[] softwareCategoryField;

        private string[] systemRequirementsField;

        private string versionField;

        private string numberOfUsersField;

        private string softwareFormatField;

        private string requiredPeripheralsField;

        private string[] educationalFocusField;

        private string[] operatingSystemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("softwareCategoryValue", IsNullable = false)]
        public string[] softwareCategory
        {
            get
            {
                return this.softwareCategoryField;
            }
            set
            {
                this.softwareCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("systemRequirement", IsNullable = false)]
        public string[] systemRequirements
        {
            get
            {
                return this.systemRequirementsField;
            }
            set
            {
                this.systemRequirementsField = value;
            }
        }

        /// <remarks/>
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfUsers
        {
            get
            {
                return this.numberOfUsersField;
            }
            set
            {
                this.numberOfUsersField = value;
            }
        }

        /// <remarks/>
        public string softwareFormat
        {
            get
            {
                return this.softwareFormatField;
            }
            set
            {
                this.softwareFormatField = value;
            }
        }

        /// <remarks/>
        public string requiredPeripherals
        {
            get
            {
                return this.requiredPeripheralsField;
            }
            set
            {
                this.requiredPeripheralsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("educationalFocu", IsNullable = false)]
        public string[] educationalFocus
        {
            get
            {
                return this.educationalFocusField;
            }
            set
            {
                this.educationalFocusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("operatingSystemValue", IsNullable = false)]
        public string[] operatingSystem
        {
            get
            {
                return this.operatingSystemField;
            }
            set
            {
                this.operatingSystemField = value;
            }
        }
    }
}