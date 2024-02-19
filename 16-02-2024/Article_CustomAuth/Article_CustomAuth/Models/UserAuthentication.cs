﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Article_CustomAuth.Models
{
    public class UserAuthentication
    {
        public static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public static bool register(string username, string password)
        {
            SqlConnection con = new SqlConnection(connection);
            int roleid = 3;
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Insertusers"))
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@RoleId", roleid);

                int b = cmd.ExecuteNonQuery();
                con.Close();
                if (b > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static bool validate(string username, string password)
        {
            SqlConnection con = new SqlConnection(connection);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("ValidateUser"))
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", password);

                var b = Convert.ToBoolean(cmd.ExecuteScalar());

                if (b)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static bool IsInRole(string username, string role)
        {
            List<string> roles = ArticleDatabase.GetRolesUser(username);

            foreach(string r in roles)
            {
                if (r == role)
                {
                    return true;
                }
                
            }
            return false;

        }
    }
}