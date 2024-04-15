using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_EG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SERIALISATION
            Employee emp = new Employee(1, "Ramesh");

            string path = @"C:\Users\nikhita_palla\Documents\Github\Dotnet_Practice\06-02-2024\Serialisation\Serialisation_EG\Serialisation_Output\Sample.txt";

            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter bF = new BinaryFormatter();

            bF.Serialize(stream, emp);

            stream.Close();  // if not closed memory gets occupied

            Console.WriteLine("File created:" + path);

            Console.ReadLine();

            // DESERIALISATION

            //string path = @"C:\Users\nikhita_palla\Documents\Github\Dotnet_Practice\06-02-2024\Serialisation\Serialisation_EG\Serialisation_Output\Sample.txt";

            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            //BinaryFormatter bF = new BinaryFormatter();

            Employee obj=(Employee)bF.Deserialize(stream);
            Console.WriteLine(obj.Empid);
            Console.WriteLine(obj.Name);
            stream.Close();
            Console.ReadLine();


        }
    }
}
