using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300904358_Nahapetyan__ASS1
{
    public partial class NotificationForm : Form
    {
        CollectionHandler colList = new CollectionHandler();
        Publisher publish = new Publisher();
        

        public NotificationForm()
        {           
            InitializeComponent();
        }

        private void ManageSubBut_Click(object sender, EventArgs e)
        {
            SubscribeForm subForm = new SubscribeForm();
            subForm.Show();


        }

        private void ClosseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PublishNoteBut_Click(object sender, EventArgs e)
        {
            PublishNotificationForm publisForm = new PublishNotificationForm();
            publisForm.Show();
        }

        public void AddEmail(string subEmail)
        {
            SendViaEmail email = new SendViaEmail(subEmail);
            colList.AddEmail(email, publish);
            listBoxEmails.Items.Add(email.GetName());

            if ((listBoxEmails.Items.Count > 0) || (listBoxPhoneNums.Items.Count > 0))
            {
                PublishNoteBut.Enabled = true;
            }
        }

        public void RemoveEmail(string subEmail)
        {
            colList.RemoveEmail(subEmail, publish);
            listBoxEmails.Items.Remove(subEmail);

            if ((listBoxEmails.Items.Count == 0) && (listBoxPhoneNums.Items.Count == 0))
            {
                PublishNoteBut.Enabled = false;
            }
        }

        public void AddMobile(string subMobile)
        {
            SendViaMobile mobile = new SendViaMobile(subMobile);
            colList.AddMobile(mobile, publish);
            listBoxPhoneNums.Items.Add(mobile.GetName());

            if ((listBoxEmails.Items.Count > 0) || (listBoxPhoneNums.Items.Count > 0))
            {
                PublishNoteBut.Enabled = true;
            }
        }

        public void RemoveMobile(string subMobile)
        {
            colList.RemoveMobile(subMobile, publish);
            listBoxPhoneNums.Items.Remove(subMobile);

            if ((listBoxEmails.Items.Count == 0) && (listBoxPhoneNums.Items.Count == 0))
            {
                PublishNoteBut.Enabled = false;
            }
        }

        public bool CheckListEmail(string subEmail)
        {
            return colList.CheckColListEmail(subEmail);
        }

        public bool CheckListMobile(string subMobile)
        {
            return colList.CheckColListMobile(subMobile);
        }

        public void ReturnList(string note)
        {
            //colList.ReturnColListEmail();
            publish.PublishMessage(note);
            //System.Windows.Forms.MessageBox.Show("Notification" + "\"" + note + "\" has been published successfully to the following Subscribers:" + colList.ReturnColListEmail());           
        }
    }
}
