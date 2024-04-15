using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EG
{
    internal class Program
    {
        public delegate void AddNumsDelegate(int a, int b);
        public delegate string SayHelloDelegate(string s);
        public void addnums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string sayHello(string s)
        {
            return "Hello"+s;
        }
        static void Main(string[] args)
        {
            Program p=new Program();

            AddNumsDelegate addNumsDelegate = new AddNumsDelegate( p.addnums);

            addNumsDelegate(2, 3);

            SayHelloDelegate sayHelloDelegate = new SayHelloDelegate(sayHello);

            Console.WriteLine(sayHelloDelegate("Nikhita"));

/*
            p.addnums(1, 2);

            string greet=Program.sayHello("Nikhita");
*/
            //Console.WriteLine(greet);
        }
    }
}
