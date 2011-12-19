using System.Collections.Generic;
using System.Xml.Serialization;

namespace FellowshipTest.Models
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(ElementName = "results", Namespace = "", IsNullable = false)]
    public partial class Results
    {

        private List<Person> peopleField;

        private int countField;

        private int pageNumberField;

        private int totalRecordsField;

        private int additionalPagesField;

        //[XmlElementAttribute(IsNullable = false)]
        [XmlElement(ElementName = "person", Type = (typeof(Person)), IsNullable = false)]
        public List<Person> people
        {
            get
            {
                return this.peopleField;
            }
            set
            {
                this.peopleField = value;
            }
        }

        [XmlAttribute()]
        public int count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalRecords
        {
            get
            {
                return this.totalRecordsField;
            }
            set
            {
                this.totalRecordsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int additionalPages
        {
            get
            {
                return this.additionalPagesField;
            }
            set
            {
                this.additionalPagesField = value;
            }
        }
    }
}