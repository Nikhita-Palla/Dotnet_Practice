using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        Console.WriteLine("Printing Elements after pushing to stack");
        foreach(var i  in stack)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine(stack.Pop());
        Console.WriteLine();
        Console.WriteLine("After Popping an element");
        foreach (var i in stack)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("Getting the top element of stack: "+stack.Peek());
        Console.WriteLine();

        Console.WriteLine("Finding an element 1 in the stack: "+stack.Contains(2));
        Console.WriteLine();

        Console.WriteLine("Number of elements in the stack: "+stack.Count);
        Console.WriteLine();

        stack.Clear();
        Console.WriteLine("Clearning elements in the stack......");
        Console.WriteLine();

        Console.WriteLine("Number of elements in the stack after clearing: " + stack.Count);
        Console.WriteLine();


    }
}