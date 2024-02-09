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

                cmd.CommandText = "select * from UserTable";

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("UserId   UserName  Email  PasswordHash  RegistrationDate");
                    while (dr.Read())
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}");
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

                cmd.CommandText = "select * from UserTable";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "UserTable");

                DataTable dt = ds.Tables["UserTable"];

                Console.WriteLine("UserId   UserName  Email  PasswordHash  RegistrationDate");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}");
                    }
                }
            }


            conn.Close();
        }

        public static void read_query_connected_SP()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("getUserTable"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("UserId   UserName  Email  PasswordHash  RegistrationDate");
                    while (dr.Read())
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}");
                    }
                }

            }

            conn.Close();

        }

        public static void read_query_disconnected_SP()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("getUserTable"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "UserTable");

                DataTable dt = ds.Tables["UserTable"];

                Console.WriteLine("UserId   UserName  Email  PasswordHash  RegistrationDate");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}  {dr[4]}");
                    }
                }
            }


            conn.Close();
        }
    }
}
