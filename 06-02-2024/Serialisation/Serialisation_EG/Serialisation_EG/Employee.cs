using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_EG
{
    [Serializable]
    internal class Employee
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public Employee(int empid,string name)
        {
            Empid = empid;
            Name = name;
        }
    }
}
