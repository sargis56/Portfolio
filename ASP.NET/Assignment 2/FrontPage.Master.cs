using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _300693835_Assignment02
{
    public partial class FrontPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void shopbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }

        protected void jollyRogersTreeView_SelectedNodeChanged(object sender, EventArgs e)
        {

        }
    }
}