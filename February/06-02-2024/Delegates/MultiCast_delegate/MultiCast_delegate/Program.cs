using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast_delegate
{
    public delegate void RectangeDelegate(double a, double b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("using delegate");
            RectangeDelegate rect = new RectangeDelegate(rectangle.getPerimeter);
            rect += rectangle.getArea;

            rect(12.34, 56.78);

            Console.WriteLine();

            Console.WriteLine("Without delegate");

            rectangle.getArea(12.34, 56.78);
            rectangle.getPerimeter(12.34, 56.78);
        }
    }
}
