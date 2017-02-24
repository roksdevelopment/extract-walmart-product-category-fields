namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Movies
    {

        private MoviesMpaaRating mpaaRatingField;

        private string movieGenreField;

        private string movieSubgenreField;

        private System.DateTime theatricalReleaseDateField;

        private bool theatricalReleaseDateFieldSpecified;

        private string digitalVideoFormatsField;

        private string directorField;

        private string[] actorsField;

        private string screenwriterField;

        private string studioProductionCompanyField;

        private string videoStreamingQualityField;

        private string audioTrackCodecField;

        private TimeUnit durationField;

        private System.DateTime dvdReleaseDateField;

        private bool dvdReleaseDateFieldSpecified;

        private bool isDubbedField;

        private bool isDubbedFieldSpecified;

        private string[] dubbedLanguagesField;

        private bool hasSubtitlesField;

        private bool hasSubtitlesFieldSpecified;

        private string[] subtitledLanguagesField;

        private string seriesTitleField;

        private string numberInSeriesField;

        private string aspectRatioField;

        /// <remarks/>
        public MoviesMpaaRating mpaaRating
        {
            get
            {
                return this.mpaaRatingField;
            }
            set
            {
                this.mpaaRatingField = value;
            }
        }

        /// <remarks/>
        public string movieGenre
        {
            get
            {
                return this.movieGenreField;
            }
            set
            {
                this.movieGenreField = value;
            }
        }

        /// <remarks/>
        public string movieSubgenre
        {
            get
            {
                return this.movieSubgenreField;
            }
            set
            {
                this.movieSubgenreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime theatricalReleaseDate
        {
            get
            {
                return this.theatricalReleaseDateField;
            }
            set
            {
                this.theatricalReleaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool theatricalReleaseDateSpecified
        {
            get
            {
                return this.theatricalReleaseDateFieldSpecified;
            }
            set
            {
                this.theatricalReleaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string digitalVideoFormats
        {
            get
            {
                return this.digitalVideoFormatsField;
            }
            set
            {
                this.digitalVideoFormatsField = value;
            }
        }

        /// <remarks/>
        public string director
        {
            get
            {
                return this.directorField;
            }
            set
            {
                this.directorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("actor", IsNullable = false)]
        public string[] actors
        {
            get
            {
                return this.actorsField;
            }
            set
            {
                this.actorsField = value;
            }
        }

        /// <remarks/>
        public string screenwriter
        {
            get
            {
                return this.screenwriterField;
            }
            set
            {
                this.screenwriterField = value;
            }
        }

        /// <remarks/>
        public string studioProductionCompany
        {
            get
            {
                return this.studioProductionCompanyField;
            }
            set
            {
                this.studioProductionCompanyField = value;
            }
        }

        /// <remarks/>
        public string videoStreamingQuality
        {
            get
            {
                return this.videoStreamingQualityField;
            }
            set
            {
                this.videoStreamingQualityField = value;
            }
        }

        /// <remarks/>
        public string audioTrackCodec
        {
            get
            {
                return this.audioTrackCodecField;
            }
            set
            {
                this.audioTrackCodecField = value;
            }
        }

        /// <remarks/>
        public TimeUnit duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dvdReleaseDate
        {
            get
            {
                return this.dvdReleaseDateField;
            }
            set
            {
                this.dvdReleaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dvdReleaseDateSpecified
        {
            get
            {
                return this.dvdReleaseDateFieldSpecified;
            }
            set
            {
                this.dvdReleaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDubbed
        {
            get
            {
                return this.isDubbedField;
            }
            set
            {
                this.isDubbedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDubbedSpecified
        {
            get
            {
                return this.isDubbedFieldSpecified;
            }
            set
            {
                this.isDubbedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("dubbedLanguage", IsNullable = false)]
        public string[] dubbedLanguages
        {
            get
            {
                return this.dubbedLanguagesField;
            }
            set
            {
                this.dubbedLanguagesField = value;
            }
        }

        /// <remarks/>
        public bool hasSubtitles
        {
            get
            {
                return this.hasSubtitlesField;
            }
            set
            {
                this.hasSubtitlesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSubtitlesSpecified
        {
            get
            {
                return this.hasSubtitlesFieldSpecified;
            }
            set
            {
                this.hasSubtitlesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("subtitledLanguage", IsNullable = false)]
        public string[] subtitledLanguages
        {
            get
            {
                return this.subtitledLanguagesField;
            }
            set
            {
                this.subtitledLanguagesField = value;
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

        /// <remarks/>
        public string aspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }
    }
}