using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection_EG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type T = Type.GetType("Reflection_EG.Employee");

            // Type T=typeof(Employee);
            Employee employee = new Employee();
            Type T=employee.GetType();

            Console.WriteLine($"Full Name={T.FullName}");
            Console.WriteLine($"Just Name: {T.Name}");
            Console.WriteLine($"Just the Namespace:{T.Namespace}");

            Console.WriteLine();
            Console.WriteLine("Property Information");
            PropertyInfo[] property=T.GetProperties();
            foreach (PropertyInfo pi in property)
            {
                Console.WriteLine($"Type:{pi.PropertyType.Name}  Name:{pi.Name}");
               
            }

            Console.WriteLine();
            Console.WriteLine("FieldInfo");
            FieldInfo[] fields=T.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"Field Name: {field.Name}");
                Console.WriteLine($"Field Type: {field.FieldType}");
                Console.WriteLine($"Is Public: {field.IsPublic}");
                Console.WriteLine($"Is Private: {field.IsPrivate}");
                Console.WriteLine($"Is Static: {field.IsStatic}");
                Console.WriteLine();

            }


            Console.WriteLine();
            Console.WriteLine("Method Information");
            MethodInfo[] methodInfo=T.GetMethods();
            foreach (MethodInfo mi in methodInfo)
            {
                Console.WriteLine($"Method return Type:{mi.ReturnType.Name}  Method Name: {mi.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Constructor Information");
            ConstructorInfo[] constructors=T.GetConstructors();
            foreach(ConstructorInfo ci in constructors)
            {
                Console.WriteLine(ci.Name+" "+ci.GetType().Name+" "+ci.ToString());
            }
         

            // Display initial values
            Console.WriteLine("Initial values:");
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}");

            // Get the type of Employee
            Type employeeType = typeof(Employee);

            // Change properties using reflection
            PropertyInfo idProperty = employeeType.GetProperty("Id");
            idProperty.SetValue(employee, 100); // Set new value for Id

            PropertyInfo nameProperty = employeeType.GetProperty("Name");
            nameProperty.SetValue(employee, "Jane"); // Set new value for Name

            // Display updated values
            Console.WriteLine("\nUpdated values:");
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}");

            Console.ReadLine();

        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string val;
        private string Age { get;set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Employee()
        {
            Id = -1;
            Name = null;
        }
    }
}
