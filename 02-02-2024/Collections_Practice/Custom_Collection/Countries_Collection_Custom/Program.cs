using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomArrayList_Class;


namespace Countries_Collection_Custom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList<string> countries = new CustomArrayList<string>();
            countries.AddFirst("India");
        
            countries.AddLast("USA");


            Console.WriteLine("After Adding first and last countries:");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            List<string> countryList = new List<string>() { "Canada", "France", "Germany", "Japan" };
            countries.AddRange(countryList);

            Console.WriteLine("After Adding Multiple countries at a time:");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();



            countries.RemoveFirst();
            countries.RemoveLast();

            Console.WriteLine("After Removing first and last country of the list:");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            countries.Remove("France");
            Console.WriteLine("After Removing France:");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            countries.InsertAt(2, "Australia");

            Console.WriteLine("After Inserting country at Index 2:Australia");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            countries.DeleteAt(3);
            Console.WriteLine("After deleting country at Index 3");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();



            string[] array = countries.ToArray();
            Console.WriteLine("Converted to Array:");
            foreach (string country in array)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

