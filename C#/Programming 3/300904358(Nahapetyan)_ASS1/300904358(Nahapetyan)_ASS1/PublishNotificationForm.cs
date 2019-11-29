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
    public partial class PublishNotificationForm : Form
    {
        NotificationForm notForm = Application.OpenForms.Cast<NotificationForm>().Last();


        public PublishNotificationForm()
        {
            InitializeComponent();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PublishBut_Click(object sender, EventArgs e)
        {
            if (NoteConTextBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("No notification to publish");
            }
            else
            {
                notForm.ReturnList(NoteConTextBox.Text);
            }
        }
    }
}
