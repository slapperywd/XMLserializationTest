using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLserializationTest.Model
{
    public class XmlDeserializer
    {
        public static T Read<T>(string name)
        {
            T entity;
            var xs = new XmlSerializer(typeof(T));
            using (Stream sr = File.OpenRead($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\{name}"))
            {
                entity = (T)xs.Deserialize(sr);
            }
            return entity;
        }
    }
}
