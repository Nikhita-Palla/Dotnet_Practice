using System;

// Base class with various access modifiers
public class Animal
{
    // Public field
    public string PublicField = "I am a public field.";

    // Private field
    private string privateField = "I am a private field.";

    // Protected field
    protected string protectedField = "I am a protected field.";

    // Internal field
    internal string internalField = "I am an internal field.";

    // Protected internal field
    protected internal string protectedInternalField = "I am a protected internal field.";

    // Public method
    public void PublicMethod()
    {
        Console.WriteLine("Public method can be accessed from anywhere.");
    }

    // Private method
    private void PrivateMethod()
    {
        Console.WriteLine("Private method can only be accessed within the same class.");
    }

    // Protected method
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method can be accessed within the same class or derived classes.");
    }

    // Internal method
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method can be accessed within the same assembly (project).");
    }

    // Protected internal method
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected internal method can be accessed within the same assembly or derived classes.");
    }
}

// Derived class inheriting from the base class
public class Dog : Animal
{
    // Additional method in the derived class
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }

    // Accessing a protected member from the base class
    public void AccessProtectedField()
    {
        Console.WriteLine("Accessing protected field from the base class: " + protectedField);
    }
}

// Program class with the Main method
namespace Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Animal class
            Animal animal = new Animal();

            // Accessing public members
            Console.WriteLine(animal.PublicField);
            animal.PublicMethod();

            // Uncommenting the lines below will result in compilation errors
            // as private, protected members are not accessible here.
            // Console.WriteLine(animal.privateField);
            // animal.PrivateMethod();
            // Console.WriteLine(animal.protectedField);
            // animal.ProtectedMethod();
            Console.WriteLine(animal.internalField);
            animal.InternalMethod();


            Console.WriteLine(animal.protectedInternalField);
            animal.ProtectedInternalMethod();

            // Creating an instance of the Dog class
            Dog dog = new Dog();

            // Accessing public members from the derived class
            Console.WriteLine(dog.PublicField);
            dog.PublicMethod();


            dog.AccessProtectedField();


            // Uncommenting the lines below will result in compilation errors
            // as private, internal, and protected internal members are not accessible here.
            // Console.WriteLine(dog.privateField);
            // dog.PrivateMethod();
            Console.WriteLine(dog.internalField);
            dog.InternalMethod();
            Console.WriteLine(dog.protectedInternalField);
            dog.ProtectedInternalMethod();

            // Calling a method specific to the derived class
            dog.Bark();
        }
    }
}
