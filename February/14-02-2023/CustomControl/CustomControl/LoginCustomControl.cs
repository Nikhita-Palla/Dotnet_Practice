using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControl
{
    
    [ToolboxData("<{0}:LoginCustomControl runat=server></{0}:LoginCustomControl>")]
    public class LoginCustomControl : CompositeControl
    {
        Label lblusername;
        Label lblpassword;
        TextBox textBox1;
        TextBox textBox2;
        Button button1;
        LiteralControl lt1;
        Label label1;

        protected override void CreateChildControls()
        {
            lblusername = new Label();
            lblusername.Text = "Enter UserName";
            lblusername.Width = Unit.Pixel(130);


        }
    }
}
