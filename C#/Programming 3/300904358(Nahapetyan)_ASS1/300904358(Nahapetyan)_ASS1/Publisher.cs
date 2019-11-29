using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS1
{
    class Publisher
    {
        public delegate void PublishMessageDel(string msg);

        public PublishMessageDel publishmsg = null;

        public void PublishMessage(string message)
        {
            publishmsg.Invoke(message);
        }

    }
}
