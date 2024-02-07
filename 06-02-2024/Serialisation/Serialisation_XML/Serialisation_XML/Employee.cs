using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_XML
{
    [Serializable]
    public class Employee
    {
        public int Empid { get;set; }
        public string Name { get;set; }

        public Employee() { }
        public Employee(int empid,string name)
        {
            Empid = empid;
            Name = name;
        }
    }
}
