using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Database_Connectivity_Category
{
    internal class Update_query
    {
        public static void update_query(int CategoryId, string NewDescription)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update CategoryTable set Description=@NewDescription where CategoryId=@CategoryId";

                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
                cmd.Parameters.AddWithValue("@NewDescription", NewDescription);

                int rows=cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    Console.WriteLine("Updated successfully!");
                }
                else
                {
                    Console.WriteLine("Can't Update!");
                }

            }
            conn.Close();
            
        }
        public static void update_query_SP(int CategoryId, string NewDescription)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using(SqlCommand cmd = new SqlCommand("updateDescriptionInCategoryId"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
                cmd.Parameters.AddWithValue("@NewDescription", NewDescription);

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    Console.WriteLine("Updated successfully with Stored proceedure!");
                }
                else
                {
                    Console.WriteLine("Can't Update!");
                }

            }
            conn.Close();
            

        }
    }
}
