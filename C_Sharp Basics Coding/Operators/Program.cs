using System;

class Program
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 5;
        int b = 2;
        int sum = a + b; // 7
        int difference = a - b; // 3
        int product = a * b; // 10
        int quotient = a / b; // 2
        int remainder = a % b; // 1

        Console.WriteLine($"Arithmetic Operators: Sum :{sum}, Difference :{difference}, Product : {product}, Quotient : {quotient}, Remainder : {remainder}");

        // Comparison Operators
        int x = 5;
        int y = 10;
        bool isEqual = x == y; // false
        bool isNotEqual = x != y; // true
        bool isLessThan = x < y; // true
        bool isGreaterThan = x > y; // false

        Console.WriteLine($"Comparison Operators: IsEqual : {isEqual}, IsNotEqual : {isNotEqual}, IsLessThan : {isLessThan}, IsGreaterThan : {isGreaterThan}");

        // Logical Operators
        bool condition1 = true;
        bool condition2 = false;

        bool resultAnd = condition1 && condition2; // false
        bool resultOr = condition1 || condition2; // true
        bool resultNot = !condition1; // false

        Console.WriteLine($"Logical Operators: And : {resultAnd}, Or : {resultOr}, Not : {resultNot}");

        // Assignment Operators
        int num = 5;
        Console.WriteLine($"Assignment Operators:(Initial num={num})");
        num += 3; // num is now 8
        Console.WriteLine($"After using Addition assignment operator:{num}");
        num -= 2; // num is now 6
        Console.WriteLine($"After using Subtraction assignment operator:{num}");
        num *= 4; // num is now 24
        Console.WriteLine($"After using Multiplication assignment operator:{num}");
        num /= 3; // num is now 8
        Console.WriteLine($"After using division assignment operator:{num}");
        num %= 5; // num is now 3
        Console.WriteLine($"After using Remainder assignment operator:{num}");


        // Increment and Decrement Operators
        int counter = 10;
        Console.WriteLine($"Increment and Decrement Operators: counter={counter}");
        counter++; // counter is now 11
        Console.WriteLine($"After Increment: {counter}");
        counter--; // counter is now 10
        Console.WriteLine($"After Decrement: {counter}");



        // Conditional Operator (Ternary Operator)
        int value = 5;
        string result = (value > 0) ? "Positive" : "Non-positive";

        Console.WriteLine($"Conditional Operator: {result}");
    }
}
