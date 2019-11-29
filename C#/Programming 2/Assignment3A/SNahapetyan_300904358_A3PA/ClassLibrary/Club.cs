//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3PA
//File Name: Club.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Club
    {
        private uint clubRegistNum;
        private string name;
        private UInt32 phoneNumber;
        private Address clubAddress;
        private Registrant[] swimmers = new Registrant[20];
        private int swimmerArrayNum = 0;
        private ClubsManager clubManager;
        public Club()
        {

        }

        public Club(string name, Address clubAddress, UInt32 phoneNumber)
        {
            this.ClubRegistNum = clubRegistNum;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.ClubAddress = clubAddress;
        }

        public Club(uint clubRegistNum, string name, Address clubAddress, UInt32 phoneNumber)
        {
            this.ClubRegistNum = clubRegistNum;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.ClubAddress = clubAddress;
        }

        public Registrant[] Swimmers
        {
            set
            {
                swimmers = value;
            }
            get
            {
                return swimmers;
            }
        }

        public uint ClubRegistNum
        {
            set
            {
                clubRegistNum = value;
            }
            get
            {
                return clubRegistNum;
            }
        }

        public int SwimmerArrayNum
        {
            set
            {
                swimmerArrayNum = value;
            }
            get
            {
                return swimmerArrayNum;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public UInt32 PhoneNumber
        {
            set
            {
                phoneNumber = value;
            }
            get
            {
                return phoneNumber;
            }
        }

        public Address ClubAddress
        {
            set
            {
                clubAddress = value;
            }
            get
            {
                return clubAddress;
            }
        }

        public void AddSwimmer(Registrant swimmer)
        {
            //Array.IndexOf(swimmers, swimmer) != -1
            if (swimmer.Club != null)
            {
                throw new Exception("Swimmer already assigned to " + swimmer.Club.Name + " club.");
            }
            else
            {
                swimmers[swimmerArrayNum] = swimmer;
                swimmerArrayNum++;
                swimmer.Club = this;
            }
        }

        public string GetInfo()
        {
            string eventString = "\n\t";

            for (int i = 0; i < swimmerArrayNum; i++)
            {
                Registrant currentRegist = swimmers[i];
                eventString += swimmers[i].Name;
            }

            string returnString = string.Format("Name: {0}\nAdress:\n   {1}\n   {2}\n   {3}\n   {4}\nPhone: {5}\nReg number: \nSwimmers: {6}", Name, ClubAddress.AddressStreet, ClubAddress.City, ClubAddress.Province, ClubAddress.Postal, PhoneNumber, eventString);
            return returnString;
        }

    }
}
