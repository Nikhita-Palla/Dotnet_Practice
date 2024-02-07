using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate_EG
{
    internal class Program
    {
        public delegate string greetDelegate(string s);
         
        
        static void Main(string[] args)
        {
            greetDelegate del = delegate (string s)
            {
                return "Hello " + s;
            };
            Console.WriteLine(del("Scott"));
        }
    }
}
