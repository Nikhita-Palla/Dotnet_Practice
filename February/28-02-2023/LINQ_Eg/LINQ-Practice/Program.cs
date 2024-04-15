using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "a", "p", "p", "l", "e" };

            var freqCharQuery = from str in list
                                group str by str into newGroup
                                select new { Number = newGroup.Key, Count = newGroup.Count() };

            Console.WriteLine();
            foreach (var item in freqCharQuery)
            {
                Console.WriteLine("Number:" + item.Number + " Frequency:" + item.Count);
            }
            Console.WriteLine();

            var freqCharMethod = list.GroupBy(x => x).Select(x => new { Character = x.Key, Frequency = x.Count() });

            Console.WriteLine();
            foreach (var item in freqCharMethod)
            {
                Console.WriteLine($"Character: {item.Character}, Frequency: {item.Frequency}");
            }
            Console.WriteLine();

            //o display numbers, multiplication of numbers with frequency and the
            //frequency of a number in an array.
            List<int> list1 = new List<int> { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var query=from l in list1 
                      group l by l into newGroup
                      select new {Number=newGroup.Key, Multiplication=newGroup.Key*newGroup.Count(),Count=newGroup.Count() };

            Console.WriteLine();
            foreach (var item in query)
            {
                Console.WriteLine($"Number:{item.Number},Product:{item.Multiplication},Count:{item.Count}");
            }
            Console.WriteLine();

            var method = list1.GroupBy(x => x).Select(x => new {Number=x.Key,Multiplication=x.Key*x.Count(),Count=x.Count() });

            Console.WriteLine();
            foreach (var item in method)
            {
                Console.WriteLine($"Number:{item.Number},Product:{item.Multiplication},Count:{item.Count}");
            }
            Console.WriteLine();

            List<string> list2 = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var query1 = from l in list2
                        where l.StartsWith("A")
                        where l.EndsWith("M")
                        select l;
            Console.WriteLine();
            foreach(var item in query1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var method1=list2.Where(x=> x.StartsWith("A")).Where(x=>x.EndsWith("M"));

            Console.WriteLine();
            foreach (var item in method1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}
