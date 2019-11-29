using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class GamesPage_OneBone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GameInformation oneBoneInfo;
            oneBoneInfo = DatabaseConnection.GetGameInfo(100);
            lblGameTitle.Text = oneBoneInfo.GameTitle;
            lblGameSeries.Text = oneBoneInfo.GameSeries;
            lblGenre.Text = oneBoneInfo.Genre;
            lblReleaseDate.Text = oneBoneInfo.ReleaseDate.ToString("dd-MMM-yyyy");
            lblRating.Text = "10+";
            lblPlatform.Text = oneBoneInfo.Platforms;
            lblMode.Text = oneBoneInfo.Modes;

            lblPublisher.Text = oneBoneInfo.Publisher;
            lblDirector.Text = oneBoneInfo.Director;
            lblProducer.Text = oneBoneInfo.Producer;
            lblProgrammer.Text = oneBoneInfo.Programmer;
            lblArtist.Text = oneBoneInfo.Artist;

            lblGameDesc.Text = oneBoneInfo.GameDescription;
        }

        protected void buy_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }

        protected void download_Click(object sender, EventArgs e)
        {
            ErrorURL.GetError = "OneBonesDemo02132Install.exe";
            Response.Redirect("404_ErrorPage.aspx");
        }
    }
}