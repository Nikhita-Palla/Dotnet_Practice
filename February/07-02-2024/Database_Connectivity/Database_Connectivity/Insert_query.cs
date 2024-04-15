using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Configuration;
using System.Xml.Linq;

namespace Database_Connectivity_Category
{
    internal class Insert_query
    {
        public static void insert_query(string name,String Description)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "INSERT INTO CategoryTable (name, Description) VALUES ( @Name, @Description)";

            // Add parameters and their values
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Description", Description);

            int rows = cmd.ExecuteNonQuery();


            conn.Close();
            if (rows > 0)
            {
                Console.WriteLine("Inserted Successfully!");
            }
            else
            {
                Console.WriteLine("Fail to insert!");
            }

        }
        public static void insert_query_SP( string name, string description)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("InsertCategory"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Inserted Successfully using stored Proceedure!");
                }
                else
                {
                    Console.WriteLine("Failed to insert!");
                }
            }
            conn.Close();
        }
    }
}
