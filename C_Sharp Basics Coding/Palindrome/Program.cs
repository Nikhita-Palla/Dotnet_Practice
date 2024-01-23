using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it is palindrome or not:");
        string s=Console.ReadLine();
        int num=int.Parse(s);
        int temp = num;
        int rem;
        int sum = 0;
        while(num>0)
        {
            //get the remainder of the number
            rem = num % 10;

            //multiply the sum with 10 and add with remainder
            sum = sum * 10 + rem;

            //get the quotient by dividing with 10
            num=num/10;
        }
        if (temp == sum)
        {
            Console.WriteLine("Palindrome!");
        }
        else
        {
            Console.WriteLine("Not a Palindrome!");
        }
    }
}