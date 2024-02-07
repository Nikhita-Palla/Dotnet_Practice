using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                // Func<> delegate with two input parameters and a return type
                Func<int, int, string> funcDelegate = (x, y) => $"Sum of {x} and {y} is {x + y}";
                Console.WriteLine(funcDelegate(3, 5)); // Output: Sum of 3 and 5 is 8

                // Action<> delegate with two input parameters and no return type
                Action<int, int> actionDelegate = (x, y) => Console.WriteLine($"Product of {x} and {y} is {x * y}");
                actionDelegate(3, 5); // Output: Product of 3 and 5 is 15

                //Predicate delegate with string as input and return type is boolean
                Predicate<string> predicateDelegate = (s) =>
                {
                    if (s.Length > 5)
                    {
                        return true;
                    }
                    return false;
                };
                Console.WriteLine("Is string length of 'How Are you?' greater than 5? " + predicateDelegate("How Are you?"));
            }
        }

    }

