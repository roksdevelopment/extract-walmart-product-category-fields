namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class PrintersScannersAndImaging
    {

        private bool hasAutomaticDocumentFeederField;

        private bool hasAutomaticDocumentFeederFieldSpecified;

        private bool hasAutomaticTwoSidedPrintingField;

        private bool hasAutomaticTwoSidedPrintingFieldSpecified;

        private decimal colorPagesPerMinuteField;

        private bool colorPagesPerMinuteFieldSpecified;

        private string maximumDocumentSizeField;

        private ResolutionUnit maximumPrintResolutionField;

        private ResolutionUnit maximumScannerResolutionField;

        private PrintersScannersAndImagingMonochromeColor monochromeColorField;

        private bool monochromeColorFieldSpecified;

        private string printingTechnologyField;

        private decimal monochromePagesPerMinuteField;

        private bool monochromePagesPerMinuteFieldSpecified;

        private string[] wirelessTechnologiesField;

        /// <remarks/>
        public bool hasAutomaticDocumentFeeder
        {
            get
            {
                return this.hasAutomaticDocumentFeederField;
            }
            set
            {
                this.hasAutomaticDocumentFeederField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticDocumentFeederSpecified
        {
            get
            {
                return this.hasAutomaticDocumentFeederFieldSpecified;
            }
            set
            {
                this.hasAutomaticDocumentFeederFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasAutomaticTwoSidedPrinting
        {
            get
            {
                return this.hasAutomaticTwoSidedPrintingField;
            }
            set
            {
                this.hasAutomaticTwoSidedPrintingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticTwoSidedPrintingSpecified
        {
            get
            {
                return this.hasAutomaticTwoSidedPrintingFieldSpecified;
            }
            set
            {
                this.hasAutomaticTwoSidedPrintingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal colorPagesPerMinute
        {
            get
            {
                return this.colorPagesPerMinuteField;
            }
            set
            {
                this.colorPagesPerMinuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colorPagesPerMinuteSpecified
        {
            get
            {
                return this.colorPagesPerMinuteFieldSpecified;
            }
            set
            {
                this.colorPagesPerMinuteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string maximumDocumentSize
        {
            get
            {
                return this.maximumDocumentSizeField;
            }
            set
            {
                this.maximumDocumentSizeField = value;
            }
        }

        /// <remarks/>
        public ResolutionUnit maximumPrintResolution
        {
            get
            {
                return this.maximumPrintResolutionField;
            }
            set
            {
                this.maximumPrintResolutionField = value;
            }
        }

        /// <remarks/>
        public ResolutionUnit maximumScannerResolution
        {
            get
            {
                return this.maximumScannerResolutionField;
            }
            set
            {
                this.maximumScannerResolutionField = value;
            }
        }

        /// <remarks/>
        public PrintersScannersAndImagingMonochromeColor monochromeColor
        {
            get
            {
                return this.monochromeColorField;
            }
            set
            {
                this.monochromeColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monochromeColorSpecified
        {
            get
            {
                return this.monochromeColorFieldSpecified;
            }
            set
            {
                this.monochromeColorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string printingTechnology
        {
            get
            {
                return this.printingTechnologyField;
            }
            set
            {
                this.printingTechnologyField = value;
            }
        }

        /// <remarks/>
        public decimal monochromePagesPerMinute
        {
            get
            {
                return this.monochromePagesPerMinuteField;
            }
            set
            {
                this.monochromePagesPerMinuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monochromePagesPerMinuteSpecified
        {
            get
            {
                return this.monochromePagesPerMinuteFieldSpecified;
            }
            set
            {
                this.monochromePagesPerMinuteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public string[] wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }
}