namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Music
    {

        private string musicGenreField;

        private string musicSubGenreField;

        private string[] performerField;

        private string songwriterField;

        private string musicMediaFormatField;

        private string musicProducerField;

        private string recordLabelField;

        private string numberOfDiscsField;

        private string numberOfTracksField;

        private System.DateTime releaseDateField;

        private bool releaseDateFieldSpecified;

        private string musicReleaseTypeField;

        private bool hasParentalAdvisoryLabelField;

        private bool hasParentalAdvisoryLabelFieldSpecified;

        private trackListing[] trackListingsField;

        private string seriesTitleField;

        private string numberInSeriesField;

        /// <remarks/>
        public string musicGenre
        {
            get
            {
                return this.musicGenreField;
            }
            set
            {
                this.musicGenreField = value;
            }
        }

        /// <remarks/>
        public string musicSubGenre
        {
            get
            {
                return this.musicSubGenreField;
            }
            set
            {
                this.musicSubGenreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("performerValue", IsNullable = false)]
        public string[] performer
        {
            get
            {
                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        /// <remarks/>
        public string songwriter
        {
            get
            {
                return this.songwriterField;
            }
            set
            {
                this.songwriterField = value;
            }
        }

        /// <remarks/>
        public string musicMediaFormat
        {
            get
            {
                return this.musicMediaFormatField;
            }
            set
            {
                this.musicMediaFormatField = value;
            }
        }

        /// <remarks/>
        public string musicProducer
        {
            get
            {
                return this.musicProducerField;
            }
            set
            {
                this.musicProducerField = value;
            }
        }

        /// <remarks/>
        public string recordLabel
        {
            get
            {
                return this.recordLabelField;
            }
            set
            {
                this.recordLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfDiscs
        {
            get
            {
                return this.numberOfDiscsField;
            }
            set
            {
                this.numberOfDiscsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfTracks
        {
            get
            {
                return this.numberOfTracksField;
            }
            set
            {
                this.numberOfTracksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime releaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified
        {
            get
            {
                return this.releaseDateFieldSpecified;
            }
            set
            {
                this.releaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string musicReleaseType
        {
            get
            {
                return this.musicReleaseTypeField;
            }
            set
            {
                this.musicReleaseTypeField = value;
            }
        }

        /// <remarks/>
        public bool hasParentalAdvisoryLabel
        {
            get
            {
                return this.hasParentalAdvisoryLabelField;
            }
            set
            {
                this.hasParentalAdvisoryLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasParentalAdvisoryLabelSpecified
        {
            get
            {
                return this.hasParentalAdvisoryLabelFieldSpecified;
            }
            set
            {
                this.hasParentalAdvisoryLabelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public trackListing[] trackListings
        {
            get
            {
                return this.trackListingsField;
            }
            set
            {
                this.trackListingsField = value;
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