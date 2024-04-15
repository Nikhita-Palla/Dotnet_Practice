using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Database_Connectivity_Category
{
    internal class Delete_query
    {
        public static void delete_query(int CategoryId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from CategoryTable where CategoryId=@CategoryId";

                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Deleted Successfully!");
                }
                else
                {
                    Console.WriteLine("Delete Failed!");
                }
            }

            conn.Close();
        }
        public static void delete_query_SP(int CategoryId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("deleteCategoryId")) 
            {
                cmd.Connection = conn;
                cmd.CommandType= CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);

                int rows=cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Deleted Successfully using StoredProceedure!");
                }
                else
                {
                    Console.WriteLine("Delete Failed!");
                }


            }


            conn.Close();
        }
    }
}
