using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast_delegate
{
    
    internal class Rectangle
    {
        public void getArea(double length,double height)
        {
            Console.WriteLine("Area:"+length * height);
        }
        public void getPerimeter(double length,double height)
        {
            Console.WriteLine("Perimeter:"+2*(length +height));
        }
    }
}
