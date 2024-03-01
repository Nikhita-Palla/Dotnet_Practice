using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupBy
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

            // Group people by their age
            var groupedPeople = people.GroupBy(p => p.Age);

            // Iterate over each group
            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"People with age {group.Key}:");
                foreach (var person in group)
                {
                    Console.WriteLine($"Name: {person.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
