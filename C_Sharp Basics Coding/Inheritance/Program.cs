using System;
class Animal
{
    public void eat()
    {
        Console.WriteLine("Eating....");
    }
    public virtual void sound()
    {
        Console.WriteLine("Make sounds");
    }
}
class Lion : Animal
{
    public override void sound()
    {
        Console.WriteLine("Roaring....");
    }
}
class Cat : Animal
{
    public override void sound()
    {
        Console.WriteLine("Meow....");
    }

}
namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lion");
            Lion lion = new Lion();
            lion.eat();
            lion.sound();

            Console.WriteLine();

            Console.WriteLine("Cat");
            Cat cat = new Cat();
            cat.eat();
            cat.sound();
        }
    }
}