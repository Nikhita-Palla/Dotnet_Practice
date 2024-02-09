using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace WindowsFormCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ItemName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                var itemname = textBox1.Text;
                var cost = Convert.ToDecimal(textBox2.Text);


                cmd.CommandText = "insert into items (itemname,cost) values(@itemname,@cost)";

                cmd.Parameters.AddWithValue("@itemname", itemname);
                cmd.Parameters.AddWithValue("@cost", cost);
                int rows=cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Cant insert!!!");
                }
                conn.Close();
                showTable();
            }

        }
         
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void showTable()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection= conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from items";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }


            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string itemName = textBox1.Text;
            decimal cost = Convert.ToDecimal(textBox2.Text);

            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retrieve the itemid from the selected row
                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["itemid"].Value);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        // Update the record where itemid matches the specified value
                        command.CommandText = "UPDATE items SET itemname = @itemName, cost = @cost WHERE itemid = @itemId";

                        command.Parameters.AddWithValue("@itemName", itemName);
                        command.Parameters.AddWithValue("@cost", cost);
                        command.Parameters.AddWithValue("@itemId", itemId);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Updated Successfully!!");
                            showTable();
                        }
                        else
                        {
                            MessageBox.Show("Update Failed");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["itemid"].Value);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        
                        command.CommandText = "DELETE FROM items WHERE itemid = @itemId";

                        command.Parameters.AddWithValue("@itemId", itemId);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Deleted Successfully!!");
                            showTable();
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }
    }
}
