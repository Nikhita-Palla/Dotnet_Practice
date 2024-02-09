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
    internal class UserCount
    {
        public static void getUserCount()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from UserTable";

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int userCount))
                {
                    Console.WriteLine($"Total users: {userCount}");
                }
                else
                {
                    Console.WriteLine("Failed to retrieve user count.");
                }
            }
            conn.Close();
        }


    
}
}
