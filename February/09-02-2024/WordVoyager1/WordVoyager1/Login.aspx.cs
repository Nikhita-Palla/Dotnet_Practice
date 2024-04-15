using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WordVoyager1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    SqlConnection con = new SqlConnection(connection);

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("checkWithEmailPassword"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Email", email2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", password2.Text.Trim());
                        int rows = (int)cmd.ExecuteScalar();

                        if (rows == 1)
                        {
                        Response.Write("<script>alert('Login successful'); window.location.href = 'home.aspx';</script> ");
                    }
                        else
                        {
                            Response.Write("<script>alert('Sorry!, No registered account with this Email');</script>");
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
