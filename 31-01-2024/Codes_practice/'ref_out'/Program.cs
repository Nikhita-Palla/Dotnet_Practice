using System;

class Program
{
    static void ModifyValueWithRef(ref int x)
    {
        x = x * 2;
    }

    static void GetValuesWithOut(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    // Without ref or out
    static void ModifyValueWithoutRefOut(int x)
    {
        x = x * 2;
    }

    static void Main()
    {
        // Without ref or out
        int numberWithoutRefOut = 5;
        Console.WriteLine($"Original value: {numberWithoutRefOut}");

        // Passing without ref or out
        ModifyValueWithoutRefOut(numberWithoutRefOut);
        Console.WriteLine($"Value after method without ref or out: {numberWithoutRefOut}");
        Console.WriteLine();

        // Using ref
        int numberWithRef = 5;
        Console.WriteLine($"Original value: {numberWithRef}");

        // Passing with ref
        ModifyValueWithRef(ref numberWithRef);
        Console.WriteLine($"Value after method with ref: {numberWithRef}");
        Console.WriteLine();

        // Using out
        int resultX, resultY;

        // Passing with out
        GetValuesWithOut(out resultX, out resultY);
        Console.WriteLine($"Values after method with out: {resultX}, {resultY}");

        //Usecase of out
        bool b = int.TryParse("STR", out int i);
        Console.WriteLine(b);
        Console.WriteLine(i);
        Console.ReadLine();
        /// <summary>
        /// This method return integer 
        /// </summary>
        ///
    }

    
}
