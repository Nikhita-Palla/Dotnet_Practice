namespace Explicit_casting
{
    public struct MyStruct
    {
        public int Value { get; set; }

        public static explicit operator int(MyStruct mystruct)
        {
            return mystruct.Value;
        }
    }

    public class StructToInt
    {
        public static void intConversion()
        {
            MyStruct mystruct = new MyStruct { Value = 40 };
            int structValue = (int)mystruct;
            Console.WriteLine(structValue);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            double d = 123.456;
            int i = (int)d;
            Console.WriteLine($"Converting double value : {d} to integer : {i}");


            float f = (float)d;
            Console.WriteLine($"Converting double value : {d} to float : {f}");

            StructToInt.intConversion();
            
        }
    }
}
