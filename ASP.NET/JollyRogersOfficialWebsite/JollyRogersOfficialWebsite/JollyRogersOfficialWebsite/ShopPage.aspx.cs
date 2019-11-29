using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class ShopPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GamesBut_Click(object sender, EventArgs e)
        {
            ShopView2.ActiveViewIndex = 0;
        }

        protected void MerchBut_Click(object sender, EventArgs e)
        {
            ShopView2.ActiveViewIndex = 1;
        }

        protected void ImageButtonMerch1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ShopPage_OfficalHat.aspx");
        }

        protected void ImageButtonGame1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ShopPage_OneBone.aspx");
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButtonShopPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }

        protected void ExecuteItemCommand(object sender, ListViewCommandEventArgs e)
        {
            string commandName = e.CommandName;
            if (commandName != "Fart")
            {
                return;
            }
            
            ListViewDataItem selectedItem = (ListViewDataItem)e.Item;
            int selectedItemIndex = selectedItem.DataItemIndex;

            Label gameTitleLabel = (Label)selectedItem.FindControl("gameTitleLabel");
            string gameTitle = gameTitleLabel.Text;

            Label gamePriceLabel = (Label)selectedItem.FindControl("PriceLabel");
            double gamePrice = Double.Parse(gamePriceLabel.Text, System.Globalization.NumberStyles.Currency);

            Label gameShipPriceLabel = (Label)selectedItem.FindControl("shipPriceLabel");
            double gameSHIPPrice = Double.Parse(gameShipPriceLabel.Text, System.Globalization.NumberStyles.Currency);

            Label gameIDLabel = (Label)selectedItem.FindControl("gameIDLabel");
            int gameID = Convert.ToInt32(gameIDLabel.Text);

            DateTime today = DateTime.Today;

            Random rnd = new Random();
            int itemID = rnd.Next(1, 100000000);

            DatabaseConnection.WriteCartInfo(gameTitle, gamePrice + gameSHIPPrice, 1, today.ToString("yyyy-MM-dd HH:mm:ss"), gameID, itemID);

            Response.Redirect("ShopPage.aspx");
        }

        protected void ExecuteItemCommandMerch(object sender, ListViewCommandEventArgs e)
        {
            string commandName = e.CommandName;
            if (commandName != "Fart2")
            {
                return;
            }

            ListViewDataItem selectedItem = (ListViewDataItem)e.Item;
            int selectedItemIndex = selectedItem.DataItemIndex;

            Label merchTitleLabel = (Label)selectedItem.FindControl("merchTitleLabel");
            string merchTitle = merchTitleLabel.Text;

            Label merchPriceLabel = (Label)selectedItem.FindControl("PriceLabel");
            double merchPrice = Double.Parse(merchPriceLabel.Text, System.Globalization.NumberStyles.Currency);

            Label merchShipPriceLabel = (Label)selectedItem.FindControl("shipPriceLabel");
            double merchSHIPPrice = Double.Parse(merchShipPriceLabel.Text, System.Globalization.NumberStyles.Currency);

            Label merchIDLabel = (Label)selectedItem.FindControl("merchIDLabel");
            int merchID = Convert.ToInt32(merchIDLabel.Text);

            DateTime today = DateTime.Today;

            Random rnd = new Random();
            int itemID = rnd.Next(1, 100000000);

            DatabaseConnection.WriteCartInfo(merchTitle, merchPrice + merchSHIPPrice, 1, today.ToString("yyyy-MM-dd HH:mm:ss"), merchID, itemID);

            Response.Redirect("ShopPage.aspx");
        }
    }
}