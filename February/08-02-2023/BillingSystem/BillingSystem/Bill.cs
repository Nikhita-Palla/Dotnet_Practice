using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BillingSystem
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void showTable()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from items";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }


            conn.Close();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                var itemname = textBox1.Text;
                var cost = Convert.ToDecimal(textBox2.Text);
                var quantity=Convert.ToInt32(numericUpDown1.Value);


                cmd.CommandText = "insert into items (itemname,quantity,cost) values(@itemname,@quantity,@cost)";

                cmd.Parameters.AddWithValue("@itemname", itemname);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@cost", cost);
                int rows = cmd.ExecuteNonQuery();
                
                if(rows<0)
                {
                    MessageBox.Show("Error!");
                    

                }
                conn.Close();
                showTable();
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                numericUpDown1.Value = 0;
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {

            dataGridView1.Dock = DockStyle.Bottom;
            showTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["itemid"].Value);
                string itemName = Convert.ToString(dataGridView1.SelectedRows[0].Cells["itemname"].Value);
                decimal itemCost = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["cost"].Value);
                int itemQuantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["quantity"].Value);

                EditForm editForm = new EditForm(itemId,itemName, itemCost, itemQuantity);
                DialogResult result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    editForm.GetEditedItemDetails(out string editedItemName, out decimal editedItemCost, out int editedItemQuantity);

                    UpdateItemInDatabase(itemId, editedItemName, editedItemCost, editedItemQuantity);

                    showTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
        private void UpdateItemInDatabase(int itemId, string itemName, decimal itemCost, int itemQuantity)
        {
            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE items SET itemname = @itemName, cost = @itemCost, quantity = @itemQuantity WHERE itemid = @itemId";

                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.Parameters.AddWithValue("@itemCost", itemCost);
                    command.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                    command.Parameters.AddWithValue("@itemId", itemId);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            decimal subtotal = 0;
            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("Receipt:");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                if (!row.IsNewRow)
                {
                    string itemName = Convert.ToString(row.Cells["itemname"].Value);
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    decimal cost = Convert.ToDecimal(row.Cells["cost"].Value);

                   
                    decimal itemSubtotal = quantity * cost;
                    subtotal += itemSubtotal;

                    receiptText.AppendLine($"{itemName} - {quantity} x {cost:C} = {itemSubtotal:C}");
                }
            }

    
            decimal gstPercentage = 5; 
            decimal gstAmount = (subtotal * gstPercentage) / 100;
            decimal totalAmount = subtotal + gstAmount;

            Reciept receiptForm = new Reciept(receiptText.ToString(), subtotal, gstAmount, totalAmount);
            receiptForm.ShowDialog();
            showTable();
            this.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    

    


