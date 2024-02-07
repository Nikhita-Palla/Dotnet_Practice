using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace DataContract_Serializer
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Empid { get; set; }
        [DataMember]
        public string Name { get; set; }


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
        }
    }
}
