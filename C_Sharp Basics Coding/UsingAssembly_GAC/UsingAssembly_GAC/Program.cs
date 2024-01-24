using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace UsingAssembly_GAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator_Assembly.Class1 calculator = new Calculator_Assembly.Class1();
            Console.WriteLine("Addition:");
            Console.WriteLine(calculator.add(1, 2));

            Console.WriteLine("Subtraction");
            Console.WriteLine(calculator.subtract(25, 2));

            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            Console.WriteLine(class1.method());
            Console.ReadLine();

        }
    }
}
