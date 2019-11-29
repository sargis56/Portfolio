using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS1
{
    class SendViaMobile
    {
        private String CellPhone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            CellPhone = phone;
        }

        private void sendMessage(string msg)
        {
            //Console.WriteLine("The message" + "\"" + msg + "\" has already texted to " + CellPhone);
            System.Windows.Forms.MessageBox.Show("The message" + "\"" + msg + "\" has been texted to " + CellPhone);
        }

        public string GetName()
        {
            return CellPhone;
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendMessage;
        }
    }
}
