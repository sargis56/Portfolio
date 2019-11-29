using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS1
{
    class SendViaEmail
    {
        private String EmailAddr { get; set; }

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            EmailAddr = emailAddr;
        }

        private void sendEmail(string msg)
        {
            //Console.WriteLine("The message" + "\"" + msg + "\" has already texted to " + EmailAddr);
            System.Windows.Forms.MessageBox.Show("The message" + "\"" + msg + "\" has been texted to " + EmailAddr);
        }

        public string GetName()
        {
            return EmailAddr;
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}
