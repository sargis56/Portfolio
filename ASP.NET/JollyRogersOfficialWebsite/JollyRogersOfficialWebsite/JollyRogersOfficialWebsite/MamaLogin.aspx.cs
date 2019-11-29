using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class MamaLogin : System.Web.UI.Page
    {
        string password = "1";
        string login = "2";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == login) && (TextBox2.Text == password))
            {
                Response.Redirect("ManagementPage.aspx");
            }
            else
            {
                Label1.Text = "Login failed";
            }
        }
    }
}