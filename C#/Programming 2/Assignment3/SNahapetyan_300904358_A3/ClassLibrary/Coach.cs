//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3
//File Name: Coach.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Coach : Registrant
    {
        private string credentials;
        private List<Swimmer> swimmers = new List<Swimmer>();

        public Coach(string name, DateTime dateOfBirth, Address address, UInt32 phoneNumber):base(name, dateOfBirth, address, phoneNumber)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Coach()
        {

        }

        public string Credentials
        {
            set
            {
                credentials = value;
            }
            get
            {
                return credentials;
            }
        }

        public void AddSwimmer(Swimmer swimmer)
        {
            swimmers.Add(swimmer);
        }

        public override string GetInfo()
        {
            if (Club == null)
            {
                ClubName = "not assigned";
            }
            else
            {
                ClubName = Club.Name;
            }

            string eventString = "";

            for (int i = 0; i < swimmers.Count; i++)
            {
                eventString += "\n\t" + swimmers[i].Name;
            }

            string returnString = string.Format("Name: {0}\nAdress: \n   {1}\n   {2}\n   {3}\n   {4}\nPhone: {5}\nDOB: {6}\nReg number: {7}\nClub: {8}\nCredentials: {9}\nSwimmers: {10}", Name, Address.AddressStreet, Address.City, Address.Province, Address.Postal, PhoneNumber, DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt"), RegistNum, ClubName, Credentials, eventString);
            return returnString;
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
