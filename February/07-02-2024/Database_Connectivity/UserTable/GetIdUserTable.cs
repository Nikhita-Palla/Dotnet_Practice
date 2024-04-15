﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTable
{
    internal class GetIdUserTable
    {
        public static int[] getIdUserTable()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();
            int[] outArray = new int[] { };
            using (SqlCommand cmd = new SqlCommand("getIdUserTable"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<int> tempList = new List<int>();

                    while (reader.Read())
                    {
                        int value;
                        if (int.TryParse(reader[0].ToString(), out value))
                        {
                            tempList.Add(value);
                        }
                    }

                    outArray = tempList.ToArray();
                }


            }
            conn.Close();
            return outArray;
           
        }
    }
}