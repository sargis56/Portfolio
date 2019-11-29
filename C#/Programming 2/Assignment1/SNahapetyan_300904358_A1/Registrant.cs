//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A1
//File Name: Registrant.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A1
{
    class Registrant
    {
        private int registNum;
        private string registName;
        private string registBrithday;
        private int registPhoneNum;
        private Address registAddress;

        public Registrant()
        {

        }

        public Registrant(int registNum, string registName, string registBrithday, int registPhoneNum, string addressStName, int addressStNum)
        {
            this.RegistNum = registNum;
            this.RegistName = registName;
            this.RegistBrithday = registBrithday;
            this.RegistPhoneNum = registPhoneNum;
            this.registAddress.AddressStreetName = addressStName;
            this.registAddress.AddressStreetNum = addressStNum;
        }

        public int RegistNum
        {
            set
            {
                registNum = value;
            }
            get
            {
                return registNum;
            }
        }

        public string RegistName
        {
            set
            {
                registName = value;
            }
            get
            {
                return registName;
            }
        }

        public string RegistBrithday
        {
            set
            {
                registBrithday = value;
            }
            get
            {
                return registBrithday;
            }
        }

        public int RegistPhoneNum
        {
            set
            {
                registPhoneNum = value;
            }
            get
            {
                return registPhoneNum;
            }
        }

        public string GetInfo()
        {
            string returnString = string.Format("Registrant Information: \nRegistrant’s registration number: {0}\nName of the registrant: {1}\nRegistrant's date of birth: {2}\nRegistrant's Telephone number: {3}\nRegistrant's address: {4} {5}\n", RegistNum, RegistName, RegistBrithday, RegistPhoneNum, registAddress.AddressStreetNum, registAddress.AddressStreetName);
            return returnString;
        }


    }

}
