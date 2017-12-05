using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLserializationTest.Model;
using XMLserializationTest.XMLentities;


namespace XMLserializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = XmlDeserializer.Read<People>("People.xml");
            foreach (var person in people.PeopleList)
            {
                Console.WriteLine($"Age : {person.Age}\nName : {person.Name}");

            }
            Console.WriteLine("Enter any key");
            Console.ReadKey();

        }
    }
}
