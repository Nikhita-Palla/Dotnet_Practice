using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriorities
{
    
    internal class Program
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
            {
                count1++;
            }

        }
        public static void IncrementCount2()
        {
            while (true)
            {
                count2++;
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

             // if we make the main thread goes to sleep then in that time the t1, t2 threads can be executed

            t1.Start();
            t2.Start();

            t1.Priority= ThreadPriority.Lowest;
            t2.Priority= ThreadPriority.Highest;   // count 2 value will be higher

            Console.WriteLine("Main thread to sleep");
            Thread.Sleep(2000);
            Console.WriteLine("Main thread wokeup");



            t1.Abort(); // terminates the thread
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("Count 1:" + count1);
            Console.WriteLine("Count 2:" + count2);

        }
    }
}
