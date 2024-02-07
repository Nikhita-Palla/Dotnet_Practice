using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate string greedDelegate(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
            greedDelegate del = (s)=>
            {
                return "Hello " + s;
            };
            Console.WriteLine(del("Scott"));
        }
    }
}
