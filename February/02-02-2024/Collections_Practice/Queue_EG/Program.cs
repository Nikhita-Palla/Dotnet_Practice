using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("a");
        queue.Enqueue("b");
        queue.Enqueue("c");
        queue.Enqueue("d");
        queue.Enqueue("e");

        Console.WriteLine("Printing the elements in the queue after adding into queue");
        foreach(var i in queue)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("Removing an element with dequeue"+queue.Dequeue());  // returns the element at the beginning of the queue by deleting it
        Console.WriteLine("Printing the elements in the queue after deleting from queue");
        foreach (var i in queue)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("Element at the begining of the queue: "+queue.Peek());
        Console.WriteLine();

        Console.WriteLine("Checking if 'a' is in queue:" + queue.Contains("a").ToString());
        Console.WriteLine();

        Console.WriteLine("Number if elements in the queue:"+queue.Count);
        Console.WriteLine();

        Console.WriteLine("Clearing elements from the queue........");
        queue.Clear();
        Console.WriteLine("Number if elements in the queue after clearing:" + queue.Count);

    }
}