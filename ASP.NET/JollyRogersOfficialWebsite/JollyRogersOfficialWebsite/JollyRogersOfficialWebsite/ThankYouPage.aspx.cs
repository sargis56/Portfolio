﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class ThankYouPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonReturnShop_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }

        protected void ReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}