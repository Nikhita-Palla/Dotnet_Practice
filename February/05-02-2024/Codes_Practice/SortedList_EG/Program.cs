using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(String[] args)
    {
        SortedList<int,string> keyValuePairs = new SortedList<int,string>();

        keyValuePairs.Add(1, "A");
        keyValuePairs.Add(5, "E");
        keyValuePairs.Add(3, "C");
        keyValuePairs.Add(26, "Z");
        keyValuePairs.Add(24, "X");

        Console.WriteLine(keyValuePairs[1]);

        keyValuePairs.Remove(1);

        keyValuePairs.RemoveAt(0);  // after sorting it will remove the entry at the particular index

        foreach (KeyValuePair<int,string> entry in keyValuePairs)
        {
            Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
        }
    }
}