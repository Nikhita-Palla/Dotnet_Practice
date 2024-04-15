class Program
{
    public static void tryParse_Eg()
    {
        bool b = int.TryParse("123f", out int res);
        Console.WriteLine(res);    // gives 0 as the parsing is not successful and default value in out parameter is 0
        Console.WriteLine(b);

        bool b1 = int.TryParse("123", out int res1);
        Console.WriteLine(res1);    // gives the converted value in the out parameter
        Console.WriteLine(b1);

    }
    public static void Main(String[] args)
    {
        tryParse_Eg();
    }
}