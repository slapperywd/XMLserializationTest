using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLserializationTest.XMLentities
{
    [XmlRoot("People")]
    public class People
    {
        [XmlElement("person")]
        public List<Person> PeopleList;
    }
}
