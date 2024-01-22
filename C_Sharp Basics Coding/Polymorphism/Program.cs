using System;

// Base class
public class Shape
{
    // Virtual method to calculate area
    public virtual void CalculateArea()
    {
        Console.WriteLine("Calculating area for a generic shape.");
    }
}

// Derived class 1
public class Circle : Shape
{
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Override method to calculate area for a circle
    public override void CalculateArea()
    {
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Calculating area for a circle: {area}");
    }
}

// Derived class 2
public class Rectangle : Shape
{
    private double length;
    private double width;

    // Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Override method to calculate area for a rectangle
    public override void CalculateArea()
    {
        double area = length * width;
        Console.WriteLine($"Calculating area for a rectangle: {area}");
    }
}
namespace Polymorphism
{

    class Program
    {
        static void Main()
        {
            // Creating instances of derived classes
            Circle myCircle = new Circle(5);
            Rectangle myRectangle = new Rectangle(4, 6);

            // Using polymorphism to treat objects as their base type (Shape)
            Shape shape1 = myCircle;
            Shape shape2 = myRectangle;

            // Calling the CalculateArea method without knowing the specific type
            shape1.CalculateArea();
            shape2.CalculateArea();
        }
    }
}