namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Media
    {

        private string titleField;

        private string[] originalLanguagesField;

        private string variantGroupIdField;

        private string[] variantAttributeNamesField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string[] awardsWonField;

        private string[] characterField;

        private string[] targetAudienceField;

        private bool isDownloadableContentAvailableField;

        private bool isDownloadableContentAvailableFieldSpecified;

        private object itemField;

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("originalLanguage", IsNullable = false)]
        public string[] originalLanguages
        {
            get
            {
                return this.originalLanguagesField;
            }
            set
            {
                this.originalLanguagesField = value;
            }
        }

        /// <remarks/>
        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public string[] variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        /// <remarks/>
        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("awardsWonValue", IsNullable = false)]
        public string[] awardsWon
        {
            get
            {
                return this.awardsWonField;
            }
            set
            {
                this.awardsWonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public string[] character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public string[] targetAudience
        {
            get
            {
                return this.targetAudienceField;
            }
            set
            {
                this.targetAudienceField = value;
            }
        }

        /// <remarks/>
        public bool isDownloadableContentAvailable
        {
            get
            {
                return this.isDownloadableContentAvailableField;
            }
            set
            {
                this.isDownloadableContentAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDownloadableContentAvailableSpecified
        {
            get
            {
                return this.isDownloadableContentAvailableFieldSpecified;
            }
            set
            {
                this.isDownloadableContentAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BooksAndMagazines", typeof(BooksAndMagazines))]
        [System.Xml.Serialization.XmlElementAttribute("Movies", typeof(Movies))]
        [System.Xml.Serialization.XmlElementAttribute("Music", typeof(Music))]
        [System.Xml.Serialization.XmlElementAttribute("TVShows", typeof(TVShows))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}