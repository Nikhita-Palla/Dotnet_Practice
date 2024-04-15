class Program
{
    public static void Parse_usecase()
    {
        string numberString = "42";
        int intValue = int.Parse(numberString);
        Console.WriteLine(intValue);

        string floatString = "123.45";
        float floatValue = float.Parse(floatString);
        Console.WriteLine(floatValue);

        string doubleString = "123.45354";
        double doubleValue = double.Parse(doubleString);
        Console.WriteLine(doubleValue);

        string numberString1 = "42FCTYFGVH";   // results in exception as number cant be converted to string
        int intValue1 = int.Parse(numberString1);
        Console.WriteLine(intValue1);    
    }
    public static void Main(String[] args)
    {
        Parse_usecase();
    }
}