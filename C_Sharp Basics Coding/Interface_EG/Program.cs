using System;


// Demonstrating Interfaces

// Define two interfaces
// multiple inheritance
public interface IDisplayable
{
    void Log();
}

public interface ILoggable
{
    void Log();
}

public class MyClass : IDisplayable, ILoggable
{
    void IDisplayable.Log()
    {
        Console.WriteLine("Displaying...");
    }

    void ILoggable.Log()
    {
        Console.WriteLine("Logging...");
    }
}

namespace Interface_EG
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass myObject = new MyClass();

            // Use methods from both interfaces explicit implementation using downcasting
            ((IDisplayable)myObject).Log();
            ((ILoggable)myObject).Log();
        }
    }
}




