using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connectivity_Category
{
    internal class Read_query
    {
        public static void read_query_connected()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from CategoryTable";

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Id  Name  Description");
                    while (dr.Read())
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}");
                    }
                }
                    
            }
            
            conn.Close();
        }

        public static void read_query_disconnected()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from CategoryTable";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CategoryTable");

                DataTable dt = ds.Tables["CategoryTable"];

                Console.WriteLine("Id  Name  Description");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}");
                    }
                }
            }
               
            
            conn.Close();
        }

        public static void read_query_connected_SP() 
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("getCategoryTable"))
            {
                cmd.Connection= conn;
                cmd.CommandType = CommandType.StoredProcedure;
                
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Id  Name  Description");
                    while (dr.Read())
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}");
                    }
                }
                   
            }
            
            conn.Close();

        }

        public static void read_query_disconnected_SP()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("getCategoryTable"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CategoryTable");

                DataTable dt = ds.Tables["CategoryTable"];

                Console.WriteLine("Id  Name  Description");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}");
                    }
                }
            }


            conn.Close();
        }



    }
}
