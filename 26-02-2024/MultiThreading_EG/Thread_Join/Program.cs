using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Join
{
    internal class Program
    {
        public static void Test1()
        {
            Console.WriteLine("Thread 1 started");
            for (int i = 0; i < 100; i++)
            {
               
                Console.WriteLine("Test1  " + i);
            }

            Console.WriteLine("Thread 1 exiting");
        }
        public static void Test2()
        {
            Console.WriteLine("Thread 2 started");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2  " + i);
            }
            Console.WriteLine("Thread 2 exiting");
        }

        public static void Test3()
        {
            Console.WriteLine("Thread 3 started");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3  " + i);
            }
            Console.WriteLine("Thread 3 exiting");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Main thread Ended");
        }
    }
}
