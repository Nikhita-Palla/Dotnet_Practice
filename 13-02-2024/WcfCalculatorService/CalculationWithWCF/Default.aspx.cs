using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculationWithWCF
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.IService1 service1=new ServiceReference1.Service1Client();
protected void Button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text=service1.sum(a,b).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text = service1.Subtract(a, b).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text = service1.Multiply(a, b).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text = service1.Divide(a, b).ToString();
        }
    }
}