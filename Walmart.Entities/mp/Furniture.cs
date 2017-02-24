namespace Walmart.Entities.mp
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://walmart.com/")]
    public partial class Furniture
    {

        private swatchImage[] swatchImagesField;

        private string collectionField;

        private string[] variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private fabricContentValue[] fabricContentField;

        private string finishField;

        private string homeDecorStyleField;

        private string[] fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string[] themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private FurnitureGender genderField;

        private bool genderFieldSpecified;

        private string[] colorField;

        private string[] ageGroupField;

        private string[] recommendedRoomsField;

        private string[] mountTypeField;

        private bool isAntiqueField;

        private bool isAntiqueFieldSpecified;

        private string[] patternField;

        private string[] materialField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private string[] characterField;

        private string powerTypeField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private string[] recommendedUsesField;

        private recycledMaterialContentValue[] recycledMaterialContentField;

        private string[] recommendedLocationsField;

        private string seatingCapacityField;

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private string numberOfDrawersField;

        private string numberOfShelvesField;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private string[] fillMaterialField;

        private string shapeField;

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public swatchImage[] swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        /// <remarks/>
        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public fabricContentValue[] fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        /// <remarks/>
        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        /// <remarks/>
        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public string[] fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        /// <remarks/>
        public string brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }

        /// <remarks/>
        public string manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public string[] theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        /// <remarks/>
        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        /// <remarks/>
        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        /// <remarks/>
        public FurnitureGender gender
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
        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public string[] ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedRoom", IsNullable = false)]
        public string[] recommendedRooms
        {
            get
            {
                return this.recommendedRoomsField;
            }
            set
            {
                this.recommendedRoomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public string[] mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
            }
        }

        /// <remarks/>
        public bool isAntique
        {
            get
            {
                return this.isAntiqueField;
            }
            set
            {
                this.isAntiqueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiqueSpecified
        {
            get
            {
                return this.isAntiqueFieldSpecified;
            }
            set
            {
                this.isAntiqueFieldSpecified = value;
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
        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfPieces
        {
            get
            {
                return this.numberOfPiecesField;
            }
            set
            {
                this.numberOfPiecesField = value;
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
        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        /// <remarks/>
        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public string[] recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public recycledMaterialContentValue[] recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public string[] recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        /// <remarks/>
        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfDrawers
        {
            get
            {
                return this.numberOfDrawersField;
            }
            set
            {
                this.numberOfDrawersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numberOfShelves
        {
            get
            {
                return this.numberOfShelvesField;
            }
            set
            {
                this.numberOfShelvesField = value;
            }
        }

        /// <remarks/>
        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
        {
            get
            {
                return this.isAssemblyRequiredFieldSpecified;
            }
            set
            {
                this.isAssemblyRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string assemblyInstructions
        {
            get
            {
                return this.assemblyInstructionsField;
            }
            set
            {
                this.assemblyInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public string[] fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        /// <remarks/>
        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Beds", typeof(Beds))]
        [System.Xml.Serialization.XmlElementAttribute("Mattresses", typeof(Mattresses))]
        [System.Xml.Serialization.XmlElementAttribute("Seating", typeof(Seating))]
        [System.Xml.Serialization.XmlElementAttribute("TVFurniture", typeof(TVFurniture))]
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