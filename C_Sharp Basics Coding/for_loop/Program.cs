using System;

class Program
{
    static void Main()
    {
        // Using for loop to print numbers from 1 to 5
        Console.WriteLine("Using for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Using foreach loop with an array
        Console.WriteLine("Using foreach loop with an array:");
        int[] numbersArray = { 10, 20, 30, 40, 50 };
        foreach (int number in numbersArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Using foreach loop with a string
        Console.WriteLine("Using foreach loop with a string:");
        string message = "Hello, C#!";
        foreach (char character in message)
        {
            Console.Write(character + " ");
        }
        Console.WriteLine();
    }
}
