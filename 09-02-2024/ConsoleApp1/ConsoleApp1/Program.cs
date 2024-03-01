using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IInterface1
    {
        void method1();
        void method2();
        
    }

    interface IInterface2 
    {
        void method1();
        void method3();
    }

    public class Child : IInterface1, IInterface2
    {
        public void method1()
        {
            Console.WriteLine("Method1");
        }
        public void method2()
        {
            Console.WriteLine("Method2 from Interface1");
        }
        public void method3()
        {
            Console.WriteLine("Method3 from interface3");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.method1();
            ch.method2();
            ch.method3();

            Console.WriteLine("-------------");

            Console.WriteLine("For Interface1");

            IInterface1 c=new Child();
            c.method1();
            c.method2();

            Console.WriteLine("-------------");
            Console.WriteLine("For Interface2");

            IInterface2 c2 = new Child();
            c2.method1();
            c2.method3();

            Console.WriteLine("Hello World!");
        }
    }
}
