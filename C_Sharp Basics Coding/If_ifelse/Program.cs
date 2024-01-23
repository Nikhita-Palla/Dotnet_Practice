using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string s= Console.ReadLine()
        int num=int.Parse(s);
        if (num > 0)
        {
            Console.WriteLine("Positive Number");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negative Number");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}