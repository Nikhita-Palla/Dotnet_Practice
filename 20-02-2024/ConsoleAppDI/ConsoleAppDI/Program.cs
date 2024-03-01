using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDI
{
    //UI
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer(new SQLDAL()); // now view is responsible for object creation. but decoupled architecture is something which shouldnt depend on any layer.
            Customer customer = new Customer();
            customer.Name = "Nikhita";
            customer.Add();
        }
    }

    //middle layer
    // middle layer is responsible for object creation, so if we remove the object creation here and it is 
    // supposed to do only business logic.
    public class Customer
    {
        private IDAL dAL;
        public Customer(IDAL obj)
        {
            dAL = obj;  
        }
        public string Name { get; set; }
        public void Add()
        {
            if (true)  // comes from config file
            {
               
                dAL.Add();
            }
            else
            {
               
                dAL.Add();
            }
        }
    }

    public interface IDAL
    {
        void Add();
    }

    //DAL
    public class SQLDAL:IDAL
    {
        public void Add()
        {
            Console.WriteLine("SQL Server inserted");
        }
    }

    public class OracleDAL:IDAL
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server inserted");
        }

        
    }

}
