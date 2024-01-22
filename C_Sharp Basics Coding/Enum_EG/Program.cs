using System;

namespace Enum_EG
{
    enum Days
    {
        Sunday,    // 0
        Monday,    // 1
        Tuesday,   // 2
        Wednesday, // 3
        Thursday,  // 4
        Friday,    // 5
        Saturday   // 6
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Using enum values
            Days today = Days.Wednesday;

            // Enum to string
            Console.WriteLine("Today is " + today);

            // Enum to int
            Console.WriteLine("Today's numeric value is " + (int)today);

            // Using switch statement with enum
            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("It's the start of the week.");
                    break;
                case Days.Saturday:
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("It's a regular day.");
                    break;
            }
        }
    }
}