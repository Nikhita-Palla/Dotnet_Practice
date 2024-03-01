using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Locking
{
    internal class Program
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("C Sharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object oriented language");
            }
            
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Thread t1 = new Thread(p.Display);
            Thread t2 = new Thread(p.Display);
            Thread t3 = new Thread(p.Display);

            t1.Start();
            t2.Start();
            t3.Start();

            p.Display();
            p.Display();
            p.Display();
        }
    }
}
