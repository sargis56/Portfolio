using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//mock password: aaaaaaaaa56A
namespace assignment01
{
    public partial class WebForm : System.Web.UI.Page
    {
        //Variables, for the textboxs' values
        string firstName;
        string lastName;
        string address;
        string city;
        string province;
        string postalCode;
        int age;
        string password;
        string confirmPassword;
        string email;
        string altEmail;
        string phone;
        string name;

        //Bool to allow the registration to continue
        bool keepReg;

        //Runs when the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            //Rests the checkbox
            keepReg = true;
            CheckBoxAM.Checked = true;
        }

        //Called when the register button is clicked
        protected void ButtonReg_Click(object sender, EventArgs e)
        {
            if (keepReg == true)
            {
                //Loops once if the user wants to register again
                for (int i = 1; i <= 1; i++)
                {
                    //Variable handeler function
                    AddValues();

                    //Clears all textboxs' values
                    TextBoxFirstName.Text = null;
                    TextBoxLastName.Text = null;
                    TextBoxAddress.Text = null;
                    TextBoxCity.Text = null;
                    TextBoxProvince.Text = null;
                    TextBoxPostalCode.Text = null;
                    TextBoxAge.Text = null;
                    TextBoxPassword.Text = null;
                    TextBoxAPassword.Text = null;
                    TextBoxEmail.Text = null;
                    TextBoxAEmail.Text = null;
                    TextBoxPhone.Text = null;
                }
            }
            else
            {
                //Variable handler function
                AddValues();
            }          
        }

        //Called when the clear button is clicked
        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            //Clears all textboxs' values
            TextBoxFirstName.Text = null;
            TextBoxLastName.Text = null;
            TextBoxAddress.Text = null;
            TextBoxCity.Text = null;
            TextBoxProvince.Text = null;
            TextBoxPostalCode.Text = null;
            TextBoxAge.Text = null;
            TextBoxPassword.Text = null;
            TextBoxAPassword.Text = null;
            TextBoxEmail.Text = null;
            TextBoxAEmail.Text = null;
            TextBoxPhone.Text = null;
        }

        //Called when the checkbox is checked
        protected void CheckBoxAM_CheckedChanged(object sender, EventArgs e)
        {
            //allow the registration to continue
            keepReg = false;
        }

        //Adds both the last name and frist name togather
        public string AddNames()
        {
            name = firstName + " " + lastName;
            return name;
        }

        //Handels variables
        public void AddValues()
        {
            //If passwords do not match then display a alert message
            if (TextBoxPassword.Text != TextBoxAPassword.Text)
            {
                //MessageBox.Show("Passwords do not match");
                ClientScript.RegisterStartupScript(this.GetType(), "alertMessagePassword", "alert('" + "Passwords do not match" + "');", true);
            }
            //If not, then add the textboxs' values into the variables and show a alert message
            else
            {
                firstName = TextBoxFirstName.Text;
                lastName = TextBoxLastName.Text;
                address = TextBoxAddress.Text;
                city = TextBoxCity.Text;
                province = TextBoxProvince.Text;
                postalCode = TextBoxPostalCode.Text;
                age = Convert.ToInt32(TextBoxAge.Text);
                password = TextBoxPassword.Text;
                confirmPassword = TextBoxAPassword.Text;
                email = TextBoxEmail.Text;
                altEmail = TextBoxAEmail.Text;
                phone = TextBoxPhone.Text;
                ClientScript.RegisterStartupScript(this.GetType(), "alertMessageSuc", "alert('" + AddNames() + ", thanks for registering with our website, your record was created successfully." + "');", true);
            }
        }

    }
}