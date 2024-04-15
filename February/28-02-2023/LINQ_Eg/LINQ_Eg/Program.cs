using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ_AggregateFunctions
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Nikhita", "Geetha", "Vyshnavi"};

            var result= list.Where(element => element.Length == 2).ToArray();

            List<int> numbers=new List<int> { 1,2,3,4,5,6,7,8,9 };

            /*var sqrt=from num in numbers 
                     let sq=Math.Sqrt(num)
                     select new {Number=num, Value=sq};*/

            var sqrt = numbers.Select(num => new { Number = num, Value = Math.Sqrt(num) });

            Console.WriteLine();            
            foreach (var num in sqrt)
            {
                Console.WriteLine(num.Number+" "+num.Value);
            }
            Console.WriteLine();

            List<int> frelist = new List<int> { 1, 1, 1, 2, 3, 4, 4, 4, 4 };
            var frequency = from fre in frelist
                            group fre by fre into newgroup
                            select new { Number = newgroup.Key, Count = newgroup.Count() };

            var frequencymethod = frelist.GroupBy(num => num).Select(num => new { Number = num, Count = num.Count() });
            Console.WriteLine();
            foreach (var fre in frequencymethod)
            {
                Console.WriteLine($"Number {fre.Number.Key} is repeated {fre.Count} times");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var fre in frequency)
            {
                Console.WriteLine($"Number {fre.Number} is repeated {fre.Count} times");
            }
            Console.WriteLine();



            var resAsc=numbers.OrderBy(element => element).ToArray();
            foreach(var item in resAsc) 
            {
                Console.WriteLine(item);
            }

            var resDesc = numbers.OrderByDescending(element => element).ToArray();
            foreach (var item in resDesc)
            {
                Console.WriteLine(item);
            }

            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 25 },
            new Person { Name = "David", Age = 30 }
        };

            var AgeAggregate = people.Aggregate(0, (sum, Person) => sum + Person.Age);

            Console.WriteLine("To find aggregate Age"+AgeAggregate.ToString());

            var groupedByAge = people.GroupBy(person => person.Age);

            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"People with age {group.Key}:");
                foreach (var person in group)
                {
                    Console.WriteLine($"- {person.Name}");
                }
                Console.WriteLine();
            }

            var resultSelect = people.Where(PeopleAge=>PeopleAge.Age>28).Select(PeopleName=>PeopleName.Name);

            foreach(var results in resultSelect)
            {
                Console.WriteLine(results);
            }

           
            var squaredNumbers = numbers.Select(n => n * n);

            var nestedLists = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5 },
                new List<int> { 6, 7, 8 }
            };

            var flattenedList = nestedLists.SelectMany(nl => nl);
            foreach(var nestedList in flattenedList)
            {
                Console.WriteLine(nestedList);
            }



        }
    }
}
