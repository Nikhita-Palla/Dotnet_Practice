class Program
{
    public static void Main(String[] args)
    {
        byte a = 255;
        int b = a;
        Console.WriteLine(b+" Type after converting byte to int "+b.GetType());
        long l = b;
        Console.WriteLine(l + " Type after converting int to long " + l.GetType());
        float f = b;
        Console.WriteLine(f + " Type after converting int to float " + f.GetType());
        decimal d = l;
        Console.WriteLine(d + " Type after converting long to decimal " + d.GetType());
        double db = f;
        Console.WriteLine(db + " Type after converting float to double " + db.GetType());
    }
}