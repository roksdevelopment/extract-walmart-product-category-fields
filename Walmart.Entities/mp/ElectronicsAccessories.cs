namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class ElectronicsAccessories
    {

        private string[] recordableMediaFormatsField;

        private string[] compatibleBrandsField;

        private string[] compatibleDevicesField;

        private string[] wirelessTechnologiesField;

        private string tvAndMonitorMountTypeField;

        private LengthUnit minimumScreenSizeField;

        private LengthUnit maximumScreenSizeField;

        private WeightUnit maximumLoadWeightField;

        private string[] headphoneFeaturesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordableMediaFormat", IsNullable = false)]
        public string[] recordableMediaFormats
        {
            get
            {
                return this.recordableMediaFormatsField;
            }
            set
            {
                this.recordableMediaFormatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public string[] compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public string[] compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
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

        /// <remarks/>
        public string tvAndMonitorMountType
        {
            get
            {
                return this.tvAndMonitorMountTypeField;
            }
            set
            {
                this.tvAndMonitorMountTypeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit minimumScreenSize
        {
            get
            {
                return this.minimumScreenSizeField;
            }
            set
            {
                this.minimumScreenSizeField = value;
            }
        }

        /// <remarks/>
        public LengthUnit maximumScreenSize
        {
            get
            {
                return this.maximumScreenSizeField;
            }
            set
            {
                this.maximumScreenSizeField = value;
            }
        }

        /// <remarks/>
        public WeightUnit maximumLoadWeight
        {
            get
            {
                return this.maximumLoadWeightField;
            }
            set
            {
                this.maximumLoadWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("headphoneFeature", IsNullable = false)]
        public string[] headphoneFeatures
        {
            get
            {
                return this.headphoneFeaturesField;
            }
            set
            {
                this.headphoneFeaturesField = value;
            }
        }
    }
}