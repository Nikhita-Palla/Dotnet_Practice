using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedDictionary<int, string> mySortedDictionary = new SortedDictionary<int, string>();

        mySortedDictionary.Add(3, "Three");
        mySortedDictionary.Add(1, "One");
        mySortedDictionary.Add(5, "Five");

        Console.WriteLine("Value of key 3: " + mySortedDictionary[3]);

        foreach (KeyValuePair<int, string> entry in mySortedDictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
