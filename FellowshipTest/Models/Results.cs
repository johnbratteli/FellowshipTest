using System.Collections.Generic;
using System.Xml.Serialization;

[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[XmlRoot(ElementName="results", Namespace = "", IsNullable = false)]
public partial class Results
{

    private List<person> peopleField;

    private int countField;

    private int pageNumberField;

    private int totalRecordsField;

    private int additionalPagesField;

    //[XmlElementAttribute(IsNullable = false)]
    [XmlElement(ElementName="person", Type=(typeof(person)), IsNullable=false)]
    public List<person> people
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