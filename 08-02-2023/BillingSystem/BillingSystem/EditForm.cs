using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class EditForm : Form
    {
        public EditForm(int itemid,string itemName, decimal itemCost, int itemQuantity)
        {
            InitializeComponent();
            itemId.Text = Convert.ToString(itemid);
            itemId.ReadOnly = true;
            itemname.Text = itemName;
            
            textBox3.Text = Convert.ToString(itemCost);
            numericUpDown1.Value = itemQuantity;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void GetEditedItemDetails(out string itemName, out decimal itemCost, out int itemQuantity)
        {
            itemName = itemname.Text;
            itemCost = Convert.ToDecimal(textBox3.Text);
            itemQuantity = (int)numericUpDown1.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;


            this.Close();
        }
    }
}
