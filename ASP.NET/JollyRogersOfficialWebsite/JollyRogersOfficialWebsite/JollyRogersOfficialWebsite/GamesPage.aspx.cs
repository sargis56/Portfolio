using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class GamesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page_100 = DatabaseConnection.GetGameTitleInfo(100);
            string page_101 = DatabaseConnection.GetGameTitleInfo(101);

            btnPage_100.Text = page_100.ToUpper();
            btnPage_101.Text = page_101.ToUpper();
            btnPage_ComingSoon.Text = "COMING SOON";
        }

        protected void btnPage_100_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesPage_100.aspx");
        }

        protected void btnPage_101_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesPage_101.aspx");
        }

        protected void btnPage_ComingSoon_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamesPage_ComingSoon.aspx");
        }
    }
}