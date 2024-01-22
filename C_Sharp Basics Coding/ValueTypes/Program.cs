using System;


// demonstrating value types
namespace ValueTypes
{
     class Program
    {
        static void Main(string[] args)
        {
            // boolean
            bool bo = false;
            Console.WriteLine("Boolean");
            Console.WriteLine("b=" + bo);
            Console.WriteLine("Type=" + bo.GetType());
            Console.WriteLine("Size=" + sizeof(bool));
            Console.WriteLine();


            // sbyte
            sbyte sb = -8;
            Console.WriteLine("Sbyte");
            Console.WriteLine("sb=" + sb);
            Console.WriteLine("Type=" + sb.GetType());
            Console.WriteLine("Size=" + sizeof(sbyte));
            Console.WriteLine("Min value of sbyte=" + sbyte.MinValue);
            Console.WriteLine("Max value of sbyte=" + sbyte.MaxValue);
            Console.WriteLine();

            // byte
            byte b = 8;
            Console.WriteLine("Byte");
            Console.WriteLine("b=" + b);
            Console.WriteLine("Type=" + b.GetType());
            Console.WriteLine("Size=" + sizeof(byte));
            Console.WriteLine("Min value of byte=" + byte.MinValue);
            Console.WriteLine("Max value of byte=" + byte.MaxValue);
            Console.WriteLine();

            // short
            short s = -1;
            Console.WriteLine("short");
            Console.WriteLine("s=" + s);
            Console.WriteLine("Type=" + s.GetType());
            Console.WriteLine("Size=" + sizeof(short));
            Console.WriteLine("Min value of short=" + short.MinValue);
            Console.WriteLine("Max value of short=" + short.MaxValue);
            Console.WriteLine();

            // ushort
            ushort us = 1;
            Console.WriteLine("Ushort");
            Console.WriteLine("us=" + us);
            Console.WriteLine("Type=" + us.GetType());
            Console.WriteLine("Size=" + sizeof(ushort));
            Console.WriteLine("Min value of ushort=" + ushort.MinValue);
            Console.WriteLine("Max value of ushort=" + ushort.MaxValue);
            Console.WriteLine();

            // int
            int i = -100;
            Console.WriteLine("int");
            Console.WriteLine("i=" + i);
            Console.WriteLine("Type=" + i.GetType());
            Console.WriteLine("Size=", sizeof(int));
            Console.WriteLine("Min value of int=" + int.MinValue);
            Console.WriteLine("Max value of int=" + int.MaxValue);
            Console.WriteLine();

            // uint
            uint ui = 100;
            Console.WriteLine("uint");
            Console.WriteLine("ui=", ui);
            Console.WriteLine("Type=" + ui.GetType());
            Console.WriteLine("Size=" + sizeof(uint));
            Console.WriteLine("Min value of uint=" + uint.MinValue);
            Console.WriteLine("Max value of uint=" + uint.MaxValue);
            Console.WriteLine();

            // long
            long l = -100000;
            Console.WriteLine("long");
            Console.WriteLine("l=" + l);
            Console.WriteLine("Type=" + l.GetType());
            Console.WriteLine("Size=" + sizeof(long));
            Console.WriteLine("Min value of long=" + long.MinValue);
            Console.WriteLine("Max value of long=" + long.MaxValue);
            Console.WriteLine();

            // ulong
            ulong ul = 100000;
            Console.WriteLine("Ulong");
            Console.WriteLine("ul=" + ul);
            Console.WriteLine("Type=" + ul.GetType());
            Console.WriteLine("Size=" + sizeof(ulong));
            Console.WriteLine("Min value of long=" + ulong.MinValue);
            Console.WriteLine("Max value of long=" + ulong.MaxValue);
            Console.WriteLine();

            // char
            char c = 'N';
            Console.WriteLine("char");
            Console.WriteLine("c = " + c);
            Console.WriteLine("Type = " + c.GetType());
            Console.WriteLine("Size " + sizeof(char));
            Console.WriteLine("Min value of char = " + (int)(char.MinValue));
            Console.WriteLine("Max value of char = " + (int)(char.MaxValue));
            Console.WriteLine();

            // float
            float fv = 123.45f;
            Console.WriteLine("Float");
            Console.WriteLine("f = " + fv);
            Console.WriteLine("Type = " + fv.GetType());
            Console.WriteLine("Size = " + sizeof(float));
            Console.WriteLine("Min value of float = " + float.MinValue);
            Console.WriteLine("Max value of float = " + float.MaxValue);
            Console.WriteLine();

            // Double
            double dv = 123.456;
            Console.WriteLine("Double");
            Console.WriteLine("d = " + dv);
            Console.WriteLine("Type = " + dv.GetType());
            Console.WriteLine("Size = " + sizeof(double));
            Console.WriteLine("Min value of double = " + double.MinValue);
            Console.WriteLine("Max value of double = " + double.MaxValue);
            Console.WriteLine();

            // Decimal
            decimal decv = 123.456m;
            Console.WriteLine("Decimal");
            Console.WriteLine("m = " + decv);
            Console.WriteLine("Type = " + decv.GetType());
            Console.WriteLine("Size = " + sizeof(decimal));
            Console.WriteLine("Min value of decimal = " + decimal.MinValue);
            Console.WriteLine("Max value of decimal = " + decimal.MaxValue);
            Console.WriteLine();

            dynamic myDynamic = 42;
            Console.WriteLine(myDynamic.GetType());
            myDynamic = "Hello, World!";
            Console.WriteLine(myDynamic.GetType());






        }
    }
}
