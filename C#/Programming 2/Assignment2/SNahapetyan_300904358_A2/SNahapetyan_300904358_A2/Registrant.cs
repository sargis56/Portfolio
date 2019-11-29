//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A2PA
//File Name: Registrant.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A2PA
{
    class Registrant
    {
        private int registNum;
        private string name;
        private DateTime dateOfBirth;
        private UInt32 phoneNumber;
        private Address address;
        private Club club;

        public Registrant()
        {

        }

        public Registrant(string name, DateTime dateOfBirth, Address address, UInt32 phoneNumber)
        {
            this.RegistNum = registNum;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Club = club;
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

        public DateTime DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
            get
            {
                return dateOfBirth;
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

        public Address Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        public Club Club
        {
            set
            {
                club = value;
            }
            get
            {
                return club;
            }
        }

        public string GetInfo()
        {
            string clubName;
            if (Club == null)
            {
                clubName = "not assigned";
            }
            else
            {
                clubName = Club.Name;
            }
            string returnString = string.Format("Name: {0}\nAdress: \n   {1}\n   {2}\n   {3}\n   {4}\nPhone: {5}\nDOB: {6}\nReg number: {7}\nClub: {8}", Name, Address.AddressStreet, Address.City, Address.Province, Address.Postal, PhoneNumber, DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt"), RegistNum, clubName);
            return returnString;
        }


    }

}
