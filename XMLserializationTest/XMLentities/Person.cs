using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLserializationTest.XMLentities
{

    public class Person
    {
        [XmlElement("age")]
        public int Age;
        
        [XmlElement("name")]
        public string Name;
    }
}
