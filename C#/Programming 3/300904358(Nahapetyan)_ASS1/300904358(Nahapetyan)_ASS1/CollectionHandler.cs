using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS1
{
    class CollectionHandler
    {

        public CollectionHandler()
        {
            
        }
 

        List<SendViaEmail> emailList = new List<SendViaEmail>();
        List<string> emailListNames = new List<string>();
        List<SendViaMobile> mobileList = new List<SendViaMobile>();
        List<string> mobileListNames = new List<string>();

        public void AddEmail(SendViaEmail email, Publisher publish)
        {
            email.Subscribe(publish);
            emailList.Add(email);
            emailListNames.Add(email.GetName());
        }

        public void RemoveEmail(string email, Publisher publish)
        {
            int emailIndex = emailListNames.FindIndex(x => x.StartsWith(email));
            emailList[emailIndex].UnSubscribe(publish);
            emailList.Remove(emailList[emailIndex]);
            emailListNames.Remove(email);
        }

        public void AddMobile(SendViaMobile mobile, Publisher publish)
        {
            mobile.Subscribe(publish);
            mobileList.Add(mobile);
            mobileListNames.Add(mobile.GetName());
        }

        public void RemoveMobile(string mobile, Publisher publish)
        {
            int mobileIndex = mobileListNames.FindIndex(x => x.StartsWith(mobile));
            mobileList[mobileIndex].UnSubscribe(publish);
            mobileList.Remove(mobileList[mobileIndex]);
            mobileListNames.Remove(mobile);
        }

        public bool CheckColListEmail(string subEmail)
        {
            if (emailListNames.Contains(subEmail))
            {
                return false;
            }
            else
            {
                return true;
            }            
        }


        public bool CheckColListMobile(string subMobile)
        {
            if (mobileListNames.Contains(subMobile))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
