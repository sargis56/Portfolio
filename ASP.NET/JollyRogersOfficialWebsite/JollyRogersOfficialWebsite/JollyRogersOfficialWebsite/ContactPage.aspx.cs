using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JollyRogersOfficialWebsite
{
    public partial class ContactPage : System.Web.UI.Page
    {
        string firstName;
        string lastName;
        string email;
        string message;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            firstName = TextBoxFirstName.Text;
            lastName = TextBoxLastName.Text;
            email = TextBoxEmail.Text;
            message = TextBoxMessage.Text;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            TextBoxFirstName.Text = null;
            TextBoxLastName.Text = null;
            TextBoxEmail.Text = null;
            TextBoxMessage.Text = null;
        }
    }
}