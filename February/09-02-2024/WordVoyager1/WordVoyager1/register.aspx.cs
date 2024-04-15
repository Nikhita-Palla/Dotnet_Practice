using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WordVoyager1
{
   
    public partial class WebForm4 : System.Web.UI.Page
    {
        private string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            string rePassword = repassword.Text.Trim();
            string Password= password.Text.Trim();
            if (rePassword != Password)
            {
                Response.Write("<script>alert('Passwords donot match');</script>");
            }
            else
            {
                if (checkUserExists())
                {
                    
                    Response.Write("<script>alert('Username or email already exists. Please choose a different one.');</script>");
                    return;
                }
                else
                {
                    registerNewUser();
                }
            }
            

        }

        bool checkUserExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(connection);

                con.Open();

                using (SqlCommand cmd = new SqlCommand("checkWithEmail"))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", email.Text.Trim());
                    
                    int rows = (int)cmd.ExecuteScalar();

                    if (rows == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    con.Close();
                }
               
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");
                
            }
            return false;
           
        }

        void registerNewUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(connection);

                con.Open();

                using (SqlCommand cmd = new SqlCommand("InsertUsers"))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", username.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", email.Text.Trim());
                    cmd.Parameters.AddWithValue("@PasswordHash", password.Text.Trim());
                    cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 1)
                    {
                        Response.Write("<script>alert('Registration successful'); window.location.href = 'login.aspx';</script> ");
                       
                    }
                    else
                    {
                        Response.Write("<script>alert('Server Issue!');</script>");
                    }
                }
                con.Close();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('" + exception.Message + "');</script>");

            }
        }
    }
}