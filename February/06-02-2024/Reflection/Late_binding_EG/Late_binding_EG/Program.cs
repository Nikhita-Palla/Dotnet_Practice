using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Late_binding_EG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();  // load the execution assembly.

            Type employeeType = assembly.GetType("Late_binding_EG.Employee");

            object employeeInstance = Activator.CreateInstance(employeeType);

            MethodInfo getFullName = employeeType.GetMethod("GetFullName");

            string[] param = new string[2];

            param[0] = "Nikhita";
            param[1] = "Palla";

            string fullName=(string)getFullName.Invoke(employeeInstance, param);
            Console.WriteLine(fullName);

            /*Employee emp = new Employee();
            Console.WriteLine(emp.getFullName("Nikhita", "Palla"));*/
        }
    }
    public class Employee
    {
        public string GetFullName(string firstName,string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
