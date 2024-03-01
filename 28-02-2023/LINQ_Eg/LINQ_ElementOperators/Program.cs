using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ElementOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] objList = { 1, 2, 3, 4, 5, 6, 7 };
            int[] objListOdd = { 1, 3, 5, 7 };
            int[] objListEven = { 2, 4, 6, 8 };

            // first() throws exception if the element is not there
            int firstEven=objList.Where(i=>i%2==0).First();
            Console.WriteLine(firstEven);
            Console.WriteLine();

            
            int firstEveninOddList= objListOdd.Where(i => i % 2 == 0).FirstOrDefault();  // gets 0, as the list has no odd element
            Console.WriteLine(firstEveninOddList);
            Console.WriteLine();

            int firstEvenInList=objList.Where(x=>x%2==0).FirstOrDefault();
            Console.WriteLine(firstEvenInList);
            Console.WriteLine();

            int LastOdd=objList.Where(x=>x%2!=0).Last();
            Console.WriteLine(LastOdd);
            Console.WriteLine();

            int LastOddInEvenList = objListEven.Where(x => x % 2 != 0).LastOrDefault();
            Console.WriteLine(LastOddInEvenList);
            Console.WriteLine();

            int LastOddList=objList.Where(x=>x%2!=0).LastOrDefault();
            Console.WriteLine(LastOddList);
            Console.WriteLine();

            //ElementAt() operator is used to return the elements from the list/collection based on the specified index.
            int elementAtIndex0 = objList.ElementAt(3);
            Console.WriteLine(elementAtIndex0);
            Console.WriteLine();

            //ElementAtOrDefault() operator is used to return the elements from the list/collection based on the specified index or else gives default value
            int elementAtIndex = objList.ElementAtOrDefault(10);
            Console.WriteLine(elementAtIndex);
            Console.WriteLine();

            //Single() method is used to return the single element from the collection, which satisfies the
            //condition. In case, if the Single() method found more than one element in collection or no element
            //in the collection, then it will throw the "InvalidOperationException" error.
            int sevenMultiple = objList.Where(x => x % 7 == 0).Single();
            Console.WriteLine(sevenMultiple);
            Console.WriteLine();

            //int even=objList.Where(x => x %2==0).Single(); // returns exception
            // int even = objList.Where(x => x % 2 == 0).SingleOrDefault(); //returns exception
            int eightMultiple = objList.Where(x => x % 8 == 0).SingleOrDefault();
            Console.WriteLine(eightMultiple);
            Console.WriteLine();

            //DefaultfEmpty() method to get the elements from the list or return the value when
            //we not found any element in the list/collection.

            int[] b = { };
            int[] a = { 1, 2, 3, 4, 5 };
            //with the help of DefaultfEmpty try to fetch the value from both of the list  
            var result = a.DefaultIfEmpty();
            var result1 = b.DefaultIfEmpty();
            Console.WriteLine("----List1 with Values----");
            //with the help of foreach loop we will print the value of 'result' variable   
            foreach (var val1 in result)
            {
                Console.WriteLine(val1);
            }
            Console.WriteLine("---List2 without Values---");
            //with the help of foreach loop we will print the value of 'result1' variable   
            foreach (var val2 in result1)
            {
                Console.WriteLine(val2);
            }

        }
    }
}
