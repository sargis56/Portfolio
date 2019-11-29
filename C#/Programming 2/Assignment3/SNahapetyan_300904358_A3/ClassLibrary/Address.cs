//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A3
//File Name: Address.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public struct Address
    {
        private string addressStreet;
        private string city;
        private string province;
        private string postal;

        public Address(string addressStreet, string city, string province, string postal) : this()
        {
            AddressStreet = addressStreet;
            City = city;
            Province = province;
            Postal = postal;
        }

        public string AddressStreet
        {
            set
            {
                addressStreet = value;
            }
            get
            {
                return addressStreet;
            }
        }

        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }

        public string Province
        {
            set
            {
                province = value;
            }
            get
            {
                return province;
            }
        }

        public string Postal
        {
            set
            {
                postal = value;
            }
            get
            {
                return postal;
            }
        }

    }
}
