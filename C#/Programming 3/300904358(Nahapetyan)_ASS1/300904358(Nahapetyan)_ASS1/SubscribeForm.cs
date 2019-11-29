using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace _300904358_Nahapetyan__ASS1
{
    public partial class SubscribeForm : Form
    {

        NotificationForm notForm = Application.OpenForms.Cast<NotificationForm>().Last();
        string emailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        string mobileRegex = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

        public SubscribeForm()
        {
       

            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = (1);
            timer.Tick += new EventHandler(Timer_Refresh);
            timer.Start();

        }

        private void Timer_Refresh(object sender, EventArgs e)
        {
            

            bool checkEmail = Regex.IsMatch(emailTextBox.Text, emailRegex, RegexOptions.IgnoreCase);
            bool checkMobile = Regex.IsMatch(mobileTextBox.Text, mobileRegex);


            if ((checkEmail == true) && emailMessageChBx.Checked)
            {
                emailPictureBox.Visible = true;
                errorEmailLabel.Visible = false;
            }
            else
            {
                emailPictureBox.Visible = false;
            }

            if ((checkMobile == true) && messageMobileChBx.Checked)
            {
                mobilePictureBox.Visible = true;
                errorMobileLabel.Visible = false;
            }
            else
            {
                mobilePictureBox.Visible = false;
            }

            this.Refresh();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubBut_Click(object sender, EventArgs e)
        {

            bool checkEmail = Regex.IsMatch(emailTextBox.Text, emailRegex, RegexOptions.IgnoreCase);
            bool checkMobile = Regex.IsMatch(mobileTextBox.Text, mobileRegex);

            if (((emailTextBox.Text == "") || (checkEmail == false)) && emailMessageChBx.Checked)
            {               
                errorEmailLabel.Visible = true;
            }
            else if (((checkEmail == true) && emailMessageChBx.Checked))
            {
                if (notForm.CheckListEmail(emailTextBox.Text) == true)
                {
                    notForm.AddEmail(emailTextBox.Text);
                    System.Windows.Forms.MessageBox.Show("Email has been added successfully");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Email already in use");
                }

            }

            if (((mobileTextBox.Text == "") || (checkMobile == false)) && messageMobileChBx.Checked)
            {
                errorMobileLabel.Visible = true;
            }
            else if ((checkMobile == true) && messageMobileChBx.Checked)
            {
                if (notForm.CheckListMobile(mobileTextBox.Text) == true)
                {
                    notForm.AddMobile(mobileTextBox.Text);
                    System.Windows.Forms.MessageBox.Show("Cell Number has been added successfully");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cell Number already in use");
                }
            }

            if ((emailMessageChBx.Checked == false) && (messageMobileChBx.Checked == false))
            {
                System.Windows.Forms.MessageBox.Show("Please check one of the check boxes");
            }
        }

        private void UnsubBut_Click(object sender, EventArgs e)
        {
            bool checkEmail = Regex.IsMatch(emailTextBox.Text, emailRegex, RegexOptions.IgnoreCase);
            bool checkMobile = Regex.IsMatch(mobileTextBox.Text, mobileRegex);

            if (((emailTextBox.Text == "") || (checkEmail == false)) && emailMessageChBx.Checked)
            {
                errorEmailLabel.Visible = true;
            }
            else if (((checkEmail == true) && emailMessageChBx.Checked))
            {
                if (notForm.CheckListEmail(emailTextBox.Text) == false)
                {
                    notForm.RemoveEmail(emailTextBox.Text);
                    System.Windows.Forms.MessageBox.Show("Email has been removed successfully");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Email not found");
                }

            }


            if (((mobileTextBox.Text == "") || (checkMobile == false)) && messageMobileChBx.Checked)
            {
                errorMobileLabel.Visible = true;
            }
            else if ((checkMobile == true) && messageMobileChBx.Checked)
            {
                if (notForm.CheckListMobile(mobileTextBox.Text) == false)
                {
                    notForm.RemoveMobile(mobileTextBox.Text);
                    System.Windows.Forms.MessageBox.Show("Cell Number has been removed successfully");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cell Number not found");
                }
            }

            if ((emailMessageChBx.Checked == false) && (messageMobileChBx.Checked == false))
            {
                System.Windows.Forms.MessageBox.Show("Please check one of the check boxes");
            }
        }

        private void emailMessageChBx_CheckedChanged(object sender, EventArgs e)
        {

            if (emailMessageChBx.Checked)
            {
                mobileTextBox.Enabled = false;
                emailTextBox.Enabled = true;
                messageMobileChBx.Enabled = false;
            }
            else
            {
                mobileTextBox.Enabled = true;
                messageMobileChBx.Enabled = true;
            }
        }

        private void messageMobileChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (messageMobileChBx.Checked)
            {
                mobileTextBox.Enabled = true;
                emailTextBox.Enabled = false;
                emailMessageChBx.Enabled = false;
            }
            else
            {
                emailTextBox.Enabled = true;
                emailMessageChBx.Enabled = true;
            }
        }
    }
}
