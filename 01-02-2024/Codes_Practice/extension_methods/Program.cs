using System.Net.Security;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello".Reverse());
    }
}

public static class StaticClass
{
    public static string Reverse(this string s)
    {
        char[] s1=s.ToCharArray();
        Array.Reverse(s1);
        return new string(s1);
    }
}