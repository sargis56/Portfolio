using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class CartPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButtonViewShop_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DatabaseConnection.CartNotEmpty() == true)
            {
                orderInfo.Text = "Order has been processed successfully";
                DatabaseConnection.ClearCart();
                Response.Redirect("ThankYouPage.aspx");
            }
            else
            {
                orderInfo.Text = "No items in cart";
            }
            
            
        }
    }
}