using System;
class Program
{
    static void Convert_Usecases()
    {
        // except DateTime and char everything can be converted to boolean. If a value is there returns true else False
        Console.WriteLine(Convert.ToBoolean(12));

        Console.WriteLine(Convert.ToDecimal(12.891));
        Console.WriteLine(Convert.ToChar(123));
        Console.WriteLine(Convert.ToString(156936.234));
        Console.WriteLine(Convert.ToByte(234));

        object result = Convert.ChangeType("123", typeof(float));
        Console.WriteLine(result.GetType());

    }
    public static void Main(String[] args)
    {
        Convert_Usecases();

    }
}