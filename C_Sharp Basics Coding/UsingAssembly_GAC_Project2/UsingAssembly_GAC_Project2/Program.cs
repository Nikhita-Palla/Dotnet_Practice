using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAssembly_GAC_Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator_Assembly.Class1 calculator = new Calculator_Assembly.Class1();

            Console.WriteLine("Multipliction");
            Console.WriteLine(calculator.multiply(12, 13));
            Console.WriteLine("Division");
            Console.WriteLine(calculator.divide(100,50));
            Console.WriteLine("Remainder");
            Console.WriteLine(calculator.remainder(20,10));
            Console.ReadLine();
        }
    }
}
