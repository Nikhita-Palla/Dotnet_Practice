using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Serialisation_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // serialisation
            /*string path = @"C:\Users\nikhita_palla\Documents\Github\Dotnet_Practice\06-02-2024\Serialisation\Serialisation_XML\Serialisation_XML\XML_file.xml";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

                Employee employee = new Employee(1, "Ramesh");

                xmlSerializer.Serialize(fs, employee);

            }
            Console.ReadLine();*/

            // deserialisation
            string path = @"C:\Users\nikhita_palla\Documents\Github\Dotnet_Practice\06-02-2024\Serialisation\Serialisation_XML\Serialisation_XML\XML_file.xml";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

                Employee emp=(Employee)xmlSerializer.Deserialize(fs);

                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Empid);
            }
            Console.ReadLine();
        }
    }
}
