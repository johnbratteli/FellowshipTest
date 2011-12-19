using System.Collections.Generic;

namespace FellowshipTest.Models
{

    // this is necessary because I couldn't find an XSD defining people
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class people
    {
        public List<Person> members { get; set; }
    }
}