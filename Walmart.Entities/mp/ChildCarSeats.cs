namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class ChildCarSeats
    {

        private string childCarSeatTypeField;

        private string facingDirectionField;

        private WeightUnit forwardFacingMinimumWeightField;

        private WeightUnit forwardFacingMaximumWeightField;

        private WeightUnit rearFacingMinimumWeightField;

        private WeightUnit rearFacingMaximumWeightField;

        private bool hasLatchSystemField;

        private bool hasLatchSystemFieldSpecified;

        /// <remarks/>
        public string childCarSeatType
        {
            get
            {
                return this.childCarSeatTypeField;
            }
            set
            {
                this.childCarSeatTypeField = value;
            }
        }

        /// <remarks/>
        public string facingDirection
        {
            get
            {
                return this.facingDirectionField;
            }
            set
            {
                this.facingDirectionField = value;
            }
        }

        /// <remarks/>
        public WeightUnit forwardFacingMinimumWeight
        {
            get
            {
                return this.forwardFacingMinimumWeightField;
            }
            set
            {
                this.forwardFacingMinimumWeightField = value;
            }
        }

        /// <remarks/>
        public WeightUnit forwardFacingMaximumWeight
        {
            get
            {
                return this.forwardFacingMaximumWeightField;
            }
            set
            {
                this.forwardFacingMaximumWeightField = value;
            }
        }

        /// <remarks/>
        public WeightUnit rearFacingMinimumWeight
        {
            get
            {
                return this.rearFacingMinimumWeightField;
            }
            set
            {
                this.rearFacingMinimumWeightField = value;
            }
        }

        /// <remarks/>
        public WeightUnit rearFacingMaximumWeight
        {
            get
            {
                return this.rearFacingMaximumWeightField;
            }
            set
            {
                this.rearFacingMaximumWeightField = value;
            }
        }

        /// <remarks/>
        public bool hasLatchSystem
        {
            get
            {
                return this.hasLatchSystemField;
            }
            set
            {
                this.hasLatchSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasLatchSystemSpecified
        {
            get
            {
                return this.hasLatchSystemFieldSpecified;
            }
            set
            {
                this.hasLatchSystemFieldSpecified = value;
            }
        }
    }
}