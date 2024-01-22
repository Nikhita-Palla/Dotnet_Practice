using System;


// Overloading
namespace Overloading
{

    class Parent
    {
        public void fun()
        {
            Console.WriteLine("Parent functionality");
        }
    }
    class Child : Parent
    {
        public void fun()
        {
            Console.WriteLine("Child functionality");
        }
        /*public void access()
        {
            this.fun();
            base.fun();
        }*/
    }
    internal class Program
    {

        public static void Main(string[] args)
        {
            Child c = new Child();
            c.fun();
            /*c.access();*/
        }


    }
}

