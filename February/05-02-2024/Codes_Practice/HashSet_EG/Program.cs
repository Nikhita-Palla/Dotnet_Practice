using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> myHashSet = new HashSet<int>();

        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Add(3);

        myHashSet.Add(2);  //duplicate element ignored

        myHashSet.Remove(3);

        bool containsElement = myHashSet.Contains(1);
        Console.WriteLine($"HashSet contains 1: {containsElement}");

        foreach (int element in myHashSet)
        {
            Console.WriteLine(element);
        }
    }
}
