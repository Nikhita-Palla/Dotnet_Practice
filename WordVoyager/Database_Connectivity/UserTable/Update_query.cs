using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTable
{
    internal class Update_query
    {
        public static void update_query(int UserId, string NewPasswordHash)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update UserTable set PasswordHash=@NewPasswordHash where UserId=@UserId";

                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@NewPasswordHash", NewPasswordHash);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
        public static void update_query_SP(int UserId, string NewPasswordHash)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("updatePasswordHash"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@NewPasswordHash", NewPasswordHash);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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
