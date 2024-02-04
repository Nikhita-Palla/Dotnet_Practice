public partial class MyClass
{
    partial void DisplayMessage(string message)
    { 
        Console.WriteLine($"Message: {message}");
    }
    public void m1()
    {
        Console.WriteLine("m1");
    }
}
public class B : MyClass
{
    public B() {
        base.m1();
        base.m3();
    }
    
}