using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Reciept : Form
    {
        public Reciept(string receiptText, decimal subtotal, decimal gstAmount, decimal totalAmount)
        {
            InitializeComponent();

            groupBox1.Text = receiptText;
            label1.Text = $"Subtotal: {subtotal:C}";
            label2.Text = $"GST: {gstAmount:C}";
            label3.Text = $"Total: {totalAmount:C}";
        }
        
        private void Reciept_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAllItemsFromTable();
            this.Close();
        }
        private void DeleteAllItemsFromTable()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM items";

                    int rows=command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Thank you for shopping");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }

    }
}
