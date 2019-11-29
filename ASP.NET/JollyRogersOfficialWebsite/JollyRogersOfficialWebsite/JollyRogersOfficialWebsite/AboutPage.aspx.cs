using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class AboutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOurCrew_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutPage_OurCrew.aspx");
        }

        protected void btnTheShip_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutPage_TheShip.aspx");
        }
    }
}