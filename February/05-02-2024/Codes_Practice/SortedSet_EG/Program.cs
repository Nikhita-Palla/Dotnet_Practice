using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<int> mySortedSet = new SortedSet<int>();

        mySortedSet.Add(5);
        mySortedSet.Add(2);
        mySortedSet.Add(8);

        mySortedSet.Add(2);  //duplicate element is ignored

        mySortedSet.Remove(5);

        bool containsElement = mySortedSet.Contains(2);
        Console.WriteLine($"SortedSet contains 2: {containsElement}");

        foreach (int element in mySortedSet)
        {
            Console.WriteLine(element);
        }
    }
}
