namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class VideoGames
    {

        private string videoGameGenreField;

        private VideoGamesEsrbRating esrbRatingField;

        private string[] sportField;

        private string[] targetAudienceField;

        private bool isOnlineMultiplayerAvailableField;

        private bool isOnlineMultiplayerAvailableFieldSpecified;

        private bool isDownloadableContentAvailableField;

        private bool isDownloadableContentAvailableFieldSpecified;

        private string editionField;

        private string videoGameCollectionField;

        private string requiredPeripheralsField;

        private string platformField;

        /// <remarks/>
        public string videoGameGenre
        {
            get
            {
                return this.videoGameGenreField;
            }
            set
            {
                this.videoGameGenreField = value;
            }
        }

        /// <remarks/>
        public VideoGamesEsrbRating esrbRating
        {
            get
            {
                return this.esrbRatingField;
            }
            set
            {
                this.esrbRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public string[] sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
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
        public bool isOnlineMultiplayerAvailable
        {
            get
            {
                return this.isOnlineMultiplayerAvailableField;
            }
            set
            {
                this.isOnlineMultiplayerAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineMultiplayerAvailableSpecified
        {
            get
            {
                return this.isOnlineMultiplayerAvailableFieldSpecified;
            }
            set
            {
                this.isOnlineMultiplayerAvailableFieldSpecified = value;
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
        public string videoGameCollection
        {
            get
            {
                return this.videoGameCollectionField;
            }
            set
            {
                this.videoGameCollectionField = value;
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
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }
    }
}