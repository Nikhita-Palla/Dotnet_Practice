public class Parent
{
    public int a;
    public int b;


    public Parent(int a)
    {
        Console.WriteLine(a);
    }
    public Parent(int a,int b) : this(2)
    {
        this.a = a;
        this.b = b;
        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine("Parent Constructor");
    }
}
public class Child : Parent
{
    public Child(int a , int b) : base(a,b)
    {
        Console.WriteLine("Child Constructor");
    }
}

namespace Constructor_chaining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Child child = new Child(2,3);
            Console.WriteLine("In main");

        }
    }
}