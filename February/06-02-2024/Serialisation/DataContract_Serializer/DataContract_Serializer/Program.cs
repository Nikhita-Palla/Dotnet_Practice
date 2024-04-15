using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContract_Serializer
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Empid { get; set; }
        [DataMember]
        public string Name { get; set; }

        public int Age { get; set; }


        public Employee(int empid, string name)
        {
            Empid = empid;
            Name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "John Doe");
            emp.Age = 1;
            string path = @"C:\Users\nikhita_palla\Documents\Github\Dotnet_Practice\06-02-2024\Serialisation\DataContract_Serializer\DataContract_Serializer\employee.xml";
            DataContractSerializer serializer = new DataContractSerializer(typeof(Employee));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.WriteObject(fs, emp);
                Console.WriteLine("Employee object serialized to employee.xml");
            }

            using (FileStream fs = new FileStream("employee.xml", FileMode.Open))
            {
                Employee deserializedEmp = (Employee)serializer.ReadObject(fs);
                Console.WriteLine($"Deserialized Employee: Empid = {deserializedEmp.Empid}, Name = {deserializedEmp.Name}");
            }
        }
    }
}
