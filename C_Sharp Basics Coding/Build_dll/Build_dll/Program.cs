using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Build_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.method());

            Console.WriteLine("Hello from EXE");
            Console.ReadLine();
        }
    }
}
