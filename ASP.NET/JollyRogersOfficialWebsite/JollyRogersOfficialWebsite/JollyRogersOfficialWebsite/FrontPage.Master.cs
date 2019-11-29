using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class FrontPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string title_100 = DatabaseConnection.GetGameTitleInfo(100);
            lbl100Title.Text = title_100;

            string title_101 = DatabaseConnection.GetGameTitleInfo(101);
            lbl101Title.Text = title_101;
        }

        protected void shopbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }

        protected void contactbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactPage.aspx");
        }
        protected void gamesbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesPage.aspx");
        }
        protected void aboutbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutPage.aspx");
        }
        protected void aboutbtn_theShip_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutPage_TheShip.aspx");
        }
        protected void aboutbtn_ourCrew_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutPage_OurCrew.aspx");
        }
        protected void loginbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MamaLogin.aspx");
        }
        
        protected void jollyRogersTreeView_SelectedNodeChanged(object sender, EventArgs e)
        {

        }
    }
}