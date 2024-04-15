using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showTable();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();
            string ename=nameText.Text.Trim();
            int eage=Convert.ToInt32(ageText.Text.Trim());  
            string edesignation=designationText.Text.Trim();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into employee(ename,eage,edesignation) values (@ename,@eage,@edesignation)";
            
            // Add parameters and their values
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@eage", eage);
            cmd.Parameters.AddWithValue("@edesignation", edesignation);
            

            int rows = cmd.ExecuteNonQuery();


            conn.Close();
            if (rows > 0)
            {
                showTable();
                Console.WriteLine("Inserted Successfully!");
            }
            else
            {
                Console.WriteLine("Fail to insert!");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTable();
        }
        void showTable()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from employee";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");

                DataTable dt = ds.Tables["Employee"];

                Console.WriteLine("EmployeeId   EmployeeName  EmployeeAge  EmployeeDesignation");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    
                    }
                }
                
            }

            


            conn.Close();
        }

        protected void rowEdit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            showTable();
        }

       

        protected void UpdateEmployee(int id, string newName, int newAge, string newDesignation)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE employee SET ename = @Name, eage = @Age, edesignation = @Designation WHERE eid = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", newName);
                    command.Parameters.AddWithValue("@Age", newAge);
                    command.Parameters.AddWithValue("@Designation", newDesignation);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

    
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Update successful');</script> ");
                    }
                    else
                    {
                        Response.Write("<script>alert('Error!');</script> ");
                    
                    }

                }
            }
        }
        
        protected void rowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            var newValues = e.NewValues;
            string updatedName = Convert.ToString(newValues["ename"]);
            int updateAge = Convert.ToInt32(newValues["eage"]);
            string updateDesignation = Convert.ToString(newValues["edesignation"]);
            int id = Convert.ToInt32(newValues["eid"]);


            UpdateEmployee(id, updatedName, updateAge, updateDesignation);
            GridView1.EditIndex = -1;
            showTable();
            
        }

        protected void cancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            showTable();
        }

        protected void rowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(e.Values["eid"]);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            con.Open();
            using (SqlCommand cmd = new SqlCommand()) 
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "delete from employee where eid=@id";
                cmd.Parameters.AddWithValue("@id", id);
                int rows=cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    showTable();
                }
                
            }
            con.Close();

        }
    }
}