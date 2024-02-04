public partial class MyClass
{
     public partial void DisplayMessage(string message);
    public void m3()
    {
        Console.WriteLine("m3");
    }
}
class C : MyClass { 
    public C() {
        base.m1();
        base.m3();
    }
    
}