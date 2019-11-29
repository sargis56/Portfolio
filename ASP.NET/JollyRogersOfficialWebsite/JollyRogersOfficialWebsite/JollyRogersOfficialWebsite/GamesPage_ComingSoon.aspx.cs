using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class GamesPage_ComingSoon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GameInformation game102Info, game103Info, game104Info;
            game102Info = DatabaseConnection.GetGameInfo(102);
            lblGameTitle102.Text = game102Info.GameTitle;
            lblGameDate102.Text = game102Info.ReleaseDate.ToString("dd-MMM-yyyy");
            lblGameDesc102.Text = game102Info.GameDescription;

            game103Info = DatabaseConnection.GetGameInfo(103);
            lblGameTitle103.Text = game103Info.GameTitle;
            lblGameDate103.Text = game103Info.ReleaseDate.ToString("dd-MMM-yyyy");
            lblGameDesc103.Text = game103Info.GameDescription;

            game104Info = DatabaseConnection.GetGameInfo(104);
            lblGameTitle104.Text = game104Info.GameTitle;
            lblGameDate104.Text = game104Info.ReleaseDate.ToString("dd-MMM-yyyy");
            lblGameDesc104.Text = game104Info.GameDescription;
        }

        protected void btnPreOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }
    }
}