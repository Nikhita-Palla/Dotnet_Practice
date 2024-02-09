using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UserTable
{
    internal class Insert_query
    {
        public static void insert_query(string UserName, String Email,String PasswordHash,DateTime RegistrationDate)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into UserTable(UserName,Email,PasswordHash,RegistrationDate) values (@UserName,@Email,@PasswordHash,@RegistrationDate)";

            // Add parameters and their values
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@PasswordHash", PasswordHash);
            cmd.Parameters.AddWithValue("@RegistrationDate", RegistrationDate);

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
        public static void insert_query_SP(string UserName, String Email, String PasswordHash, DateTime RegistrationDate)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("InsertUsers"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                cmd.Parameters.AddWithValue("@RegistrationDate", RegistrationDate);

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
