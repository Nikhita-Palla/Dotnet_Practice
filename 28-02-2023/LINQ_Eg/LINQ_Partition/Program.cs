using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_Partition
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

            var peopleTake = people.Take(2);
            foreach (var person in peopleTake)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
            Console.WriteLine();

            /*var peopleTakeWhile = people.TakeWhile(x => x.Age == 30);
            foreach (Person person in peopleTakeWhile)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }*/

            // skip method is used to with the IEnumerable to return the value which skip elements in the array
            var peopleSkip = people.Skip(1);
            foreach (var person in peopleSkip)
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
            Console.WriteLine();

            
        }
    }
}
