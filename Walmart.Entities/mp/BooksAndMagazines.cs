namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class BooksAndMagazines
    {

        private string conditionField;

        private BooksAndMagazinesGender genderField;

        private bool genderFieldSpecified;

        private string[] colorField;

        private string[] materialField;

        private string[] patternField;

        private string editionField;

        private string subjectField;

        private string bookFormatField;

        private string genreField;

        private string subgenreField;

        private string[] authorField;

        private string editorField;

        private string illustratorField;

        private string publisherField;

        private string translatorField;

        private string translatedFromField;

        private BooksAndMagazinesFictionNonfiction fictionNonfictionField;

        private bool fictionNonfictionFieldSpecified;

        private bool isUnabridgedField;

        private bool isUnabridgedFieldSpecified;

        private System.DateTime originalPublicationDateField;

        private bool originalPublicationDateFieldSpecified;

        private System.DateTime publicationDateField;

        private bool publicationDateFieldSpecified;

        private string readingLevelField;

        private string numberOfPagesField;

        private string issueField;

        private string seriesTitleField;

        private string numberInSeriesField;

        /// <remarks/>
        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        public BooksAndMagazinesGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

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
        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public string[] material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public string[] pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        /// <remarks/>
        public string edition
        {
            get
            {
                return this.editionField;
            }
            set
            {
                this.editionField = value;
            }
        }

        /// <remarks/>
        public string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        public string bookFormat
        {
            get
            {
                return this.bookFormatField;
            }
            set
            {
                this.bookFormatField = value;
            }
        }

        /// <remarks/>
        public string genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public string subgenre
        {
            get
            {
                return this.subgenreField;
            }
            set
            {
                this.subgenreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("authorValue", IsNullable = false)]
        public string[] author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public string editor
        {
            get
            {
                return this.editorField;
            }
            set
            {
                this.editorField = value;
            }
        }

        /// <remarks/>
        public string illustrator
        {
            get
            {
                return this.illustratorField;
            }
            set
            {
                this.illustratorField = value;
            }
        }

        /// <remarks/>
        public string publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        public string translator
        {
            get
            {
                return this.translatorField;
            }
            set
            {
                this.translatorField = value;
            }
        }

        /// <remarks/>
        public string translatedFrom
        {
            get
            {
                return this.translatedFromField;
            }
            set
            {
                this.translatedFromField = value;
            }
        }

        /// <remarks/>
        public BooksAndMagazinesFictionNonfiction fictionNonfiction
        {
            get
            {
                return this.fictionNonfictionField;
            }
            set
            {
                this.fictionNonfictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fictionNonfictionSpecified
        {
            get
            {
                return this.fictionNonfictionFieldSpecified;
            }
            set
            {
                this.fictionNonfictionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isUnabridged
        {
            get
            {
                return this.isUnabridgedField;
            }
            set
            {
                this.isUnabridgedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isUnabridgedSpecified
        {
            get
            {
                return this.isUnabridgedFieldSpecified;
            }
            set
            {
                this.isUnabridgedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime originalPublicationDate
        {
            get
            {
                return this.originalPublicationDateField;
            }
            set
            {
                this.originalPublicationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool originalPublicationDateSpecified
        {
            get
            {
                return this.originalPublicationDateFieldSpecified;
            }
            set
            {
                this.originalPublicationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime publicationDate
        {
            get
            {
                return this.publicationDateField;
            }
            set
            {
                this.publicationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool publicationDateSpecified
        {
            get
            {
                return this.publicationDateFieldSpecified;
            }
            set
            {
                this.publicationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string readingLevel
        {
            get
            {
                return this.readingLevelField;
            }
            set
            {
                this.readingLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        /// <remarks/>
        public string issue
        {
            get
            {
                return this.issueField;
            }
            set
            {
                this.issueField = value;
            }
        }

        /// <remarks/>
        public string seriesTitle
        {
            get
            {
                return this.seriesTitleField;
            }
            set
            {
                this.seriesTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberInSeries
        {
            get
            {
                return this.numberInSeriesField;
            }
            set
            {
                this.numberInSeriesField = value;
            }
        }
    }
}