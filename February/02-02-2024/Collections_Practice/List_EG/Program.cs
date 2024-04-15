using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of integers
        List<int> numbers = new List<int>();
        Console.WriteLine(numbers.Capacity);
        // Add elements to the List
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(50);
        Console.WriteLine(numbers.Capacity);
        
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(50);
        Console.WriteLine(numbers.Capacity);
        numbers.Add(10);
        Console.WriteLine(numbers.Capacity);
        // Display the original List
        Console.WriteLine("Original List:");
        DisplayList(numbers);

        // Insert an element at a specific index
        numbers.Insert(1, 15);

        // Display the List after insertion
        Console.WriteLine("\nList after insertion at index 1:");
        DisplayList(numbers);

        // Check if an element exists in the List
        bool containsElement = numbers.Contains(20);
        Console.WriteLine("\nList contains element 20: " + containsElement);

        // Find the index of an element
        int indexOfElement = numbers.IndexOf(30);
        Console.WriteLine("Index of element 30: " + indexOfElement);

        // Remove an element by value
        numbers.Remove(20);

        // Display the List after removal
        Console.WriteLine("\nList after removing element 20:");
        DisplayList(numbers);

        // Remove an element at a specific index
        numbers.RemoveAt(1);

        // Display the List after removal at index 1
        Console.WriteLine("\nList after removing element at index 1:");
        DisplayList(numbers);

        // Clear all elements from the List
        numbers.Clear();

        // Display the List after clearing
        Console.WriteLine("\nList after clearing:");
        DisplayList(numbers);
    }

    static void DisplayList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
