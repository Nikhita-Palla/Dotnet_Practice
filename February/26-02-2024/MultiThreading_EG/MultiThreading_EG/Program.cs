using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_EG
{
    internal class Program
    {
        public static void Test1()
        {
            for(int i=0;i<100;i++)
            {
                if (i == 50)
                {
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Test1  "+i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2  " + i);
            }
        }

        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3  " + i);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
