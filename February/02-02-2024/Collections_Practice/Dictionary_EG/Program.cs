using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "a");
        dictionary.Add(2, "b");
        dictionary.Add(3, "c");

        Console.WriteLine(dictionary[1].GetHashCode());
        Console.WriteLine(dictionary[2].GetHashCode());
        Console.WriteLine(dictionary[3].GetHashCode());

        Console.WriteLine("Keys in the Dictionary");
        foreach (var key in dictionary.Keys)
        {
            Console.Write(key + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Values in the Dictionary");
        foreach (var value in dictionary.Values)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Getting both key and value pair");

        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"Key:{pair.Key} , Value:{pair.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Checking if Key 3 is present in the dictionary: " + dictionary.ContainsKey(3));
        Console.WriteLine();

        Console.WriteLine("Checking if Value 'b' is present in the dictionary: " + dictionary.ContainsValue("b"));
        Console.WriteLine();

        Console.WriteLine("Removing an element using Key (key->1)");
        Console.WriteLine();
        dictionary.Remove(1);
        Console.WriteLine("Getting both key and value pair after removing key 1 from the dictionary");

        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"Key:{pair.Key} , Value:{pair.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Adding a new element to dictionary using item property");
        dictionary[1] = "a";  // Will set the element at key-> 1 or add a new value to the dictionary with key and that value.

        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"Key:{pair.Key} , Value:{pair.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Setting a new value ('r') at key->2");
        dictionary[2] = "r";
        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"Key:{pair.Key} , Value:{pair.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Getting a value with key (at key->2): " + dictionary[2]);

        Console.WriteLine();

        Console.WriteLine("Getting the number of key-value pairs in dictionary: " + dictionary.Count);

        Console.WriteLine();

        Console.WriteLine("Clearing the elements in the dictionary");
        dictionary.Clear();
        Console.WriteLine("Getting the number of key-value pairs in dictionary after clearing: " + dictionary.Count);
    }
}
