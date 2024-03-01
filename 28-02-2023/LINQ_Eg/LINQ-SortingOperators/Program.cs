using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SortingOperators
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 25 },
                new Person { Name = "David", Age = 30 }
            };

            Console.WriteLine("Ordering people with Age(Ascending):");

            var AgeAscending= people.OrderBy(x=>x.Age);

            foreach(Person person in AgeAscending)
            {
                Console.WriteLine("Name: "+person.Name+" Age: "+person.Age);
            }

            Console.WriteLine("Ordering people with Age(Descending):");

            var AgeDescending = people.OrderByDescending(x => x.Age);

            foreach (Person person in AgeDescending)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }

            //ThenBy operator in LINQ to implement the sorting on multiple fields
            Console.WriteLine("Ordering people with Name and Age(Ascending):");
            var AgeThenByAge=people.OrderBy(x=>x.Name).ThenBy(x=>x.Age);
            foreach (Person person in AgeThenByAge)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }

            Console.WriteLine("Ordering people with Name and Age(descending):");
            var AgeThenBydescendingAge = people.OrderBy(x => x.Name).ThenByDescending(x => x.Age);
            foreach (Person person in AgeThenBydescendingAge)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }

        }
    }
}
