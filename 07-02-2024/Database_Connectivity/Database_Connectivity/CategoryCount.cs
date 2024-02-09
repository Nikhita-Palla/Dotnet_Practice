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
    internal class CategoryCount
    {
        public static void getCategoryCount()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using(SqlCommand cmd=new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType=CommandType.Text;
                cmd.CommandText = "select count(*) from CategoryTable";

                object result=cmd.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int categorycount))
                {
                    Console.WriteLine($"Total categories: {categorycount}");
                }
                else
                {
                    Console.WriteLine("Failed to retrieve category count.");
                }
            }
            conn.Close();
        }

            
        }
    }

