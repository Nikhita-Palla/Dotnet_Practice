using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int[] numberArray = numbers.ToArray();
            Console.WriteLine(numberArray.GetType());
            Console.WriteLine();

            List<int> numberList = numbers.ToList();
            Console.WriteLine(numberList.GetType());

            Console.WriteLine();

            var persons = new[]
            {
                new { Name = "Alice", Age = 30 },
                new { Name = "Bob", Age = 25 },
                new { Name = "Bobby", Age = 30 },
                new { Name = "Dora", Age = 25 }
            };


            Dictionary<string, int> ageDictionary = persons.ToDictionary(p => p.Name, p => p.Age);

            
            foreach(var age in ageDictionary)
            {
                Console.WriteLine(age.Key+" "+age.Value);
            }
            Console.WriteLine();

            // ToLookup operator to return the collection as a key / value pair.
            var personsLookup = persons.ToLookup(p => p.Age);
            
            foreach(var person in personsLookup)
            {
                Console.WriteLine("Group1:"+person.Key);
                foreach(var item in personsLookup[person.Key])
                {
                    Console.WriteLine(item.Name+" "+item.Age);
                }
            }
            Console.WriteLine();

            // Casts each element of a sequence to a specified type.

            var objects = new object[] { "two", "four" };
            var strings = objects.Cast<string>();
            foreach(var item in strings)
            {
                Console.WriteLine(item.GetType()+" "+item);
            }

            var objects1 = new object[] { 1, "two", 3, "four", 5 };
            Console.WriteLine();

            //Filters the elements of a sequence based on a specified type.
            var strings1 = objects.OfType<string>();
            foreach (var item in strings1)
            {
                Console.WriteLine(item.GetType() + " " + item);
            }



        }
    }
}
