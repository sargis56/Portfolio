using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _300693835_Assignment02
{
    public partial class ShopPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GamesBut_Click(object sender, EventArgs e)
        {
            ShopView.ActiveViewIndex = 0;
        }

        protected void MerchBut_Click(object sender, EventArgs e)
        {
            ShopView.ActiveViewIndex = 1;
        }

        protected void ImageButtonMerch1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ShopPage_OfficalHat.aspx");
        }

        protected void ImageButtonGame1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ShopPage_OneBone.aspx");
        }
    }
}