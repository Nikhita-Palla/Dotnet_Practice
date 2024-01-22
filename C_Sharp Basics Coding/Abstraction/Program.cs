using System;
using System.Net.WebSockets;

// Abstract class representing a shape
public abstract class Shape
{
    // Abstract method for calculating area
    public abstract double CalculateArea();

    // Abstract method for displaying shape information
    public abstract void DisplayInfo();
}

// Concrete class representing a circle
public class Circle : Shape
{
    public double Radius { get; set; }

    /*public double Radius
    {
        get { return radius;}
        set {radius=value;}
    }*/

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementation of CalculateArea method
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    // Implementation of DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Circle - Radius: {Radius}, Area: {CalculateArea()}");
    }
}

// Concrete class representing a rectangle
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Implementation of CalculateArea method
    public override double CalculateArea()
    {
        return Length * Width;
    }

    // Implementation of DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Rectangle - Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
    }
}

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of concrete classes
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Using polymorphism to treat objects as their base type (Shape)
            Shape shape1 = circle;
            Shape shape2 = rectangle;

            // Calling methods without knowing the specific type
            shape1.DisplayInfo();
            shape2.DisplayInfo();
        }
    }
}