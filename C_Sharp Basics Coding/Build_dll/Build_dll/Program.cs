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

            //Abstraction.Program n = new Abstraction.Program();  private assembly is inaccessible.
            Console.WriteLine();
            
            Class2 c2 = new Class2();
            c2.m1();
            Console.ReadLine();
        }
    }
    internal class Class2: Class1
    {
        public void m1()
        {
            int id = 2;
            //Class1 c=new Class1();
           /* Console.WriteLine(c.id);*/
            Console.WriteLine(base.id);
        }
      
    }
}
