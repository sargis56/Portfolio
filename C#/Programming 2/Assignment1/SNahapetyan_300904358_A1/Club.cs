//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A1
//File Name: Club.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A1
{
    class Club
    {
        private int clubRegistNum;
        private string clubName;
        private int clubPhoneNum;
        private Address clubAddress;

        public Club()
        {

        }

        public Club(int clubRegistNum, string clubName, int clubPhoneNum, Address clubAddress)
        {
            this.ClubRegistNum = clubRegistNum;
            this.ClubName = clubName;
            this.ClubPhoneNum = clubPhoneNum;
            this.ClubAddress = clubAddress;
        }

        public int ClubRegistNum
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

        public string ClubName
        {
            set
            {
                clubName = value;
            }
            get
            {
                return clubName;
            }
        }

        public int ClubPhoneNum
        {
            set
            {
                clubPhoneNum = value;
            }
            get
            {
                return clubPhoneNum;
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

        public string GetInfo()
        {
            string returnString = string.Format("Club Information: \nClub’s registration number: {0}\nName of the club: {1}\nTelephone number: {2}\nClub address: {3} {4}\n", ClubRegistNum, ClubName, ClubPhoneNum, ClubAddress.AddressStreetNum, ClubAddress.AddressStreetName);
            return returnString;
        }

    }
}
