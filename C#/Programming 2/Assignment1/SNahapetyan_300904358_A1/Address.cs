//Author: Sargis Nahapetyan
//Student ID: 300904358
//Program Name SNahapetyan_300904358_A1
//File Name: Address.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNahapetyan_300904358_A1
{
    struct Address
    {
        private string addressStreetName;
        private int addressStreetNum;

        public Address(string addressStreetName, int addressStreetNum) : this()
        {
            AddressStreetName = addressStreetName;
            AddressStreetNum = addressStreetNum;
        }

        public string AddressStreetName
        {
            set
            {
                addressStreetName = value;
            }
            get
            {
                return addressStreetName;
            }
        }

        public int AddressStreetNum
        {
            set
            {
                addressStreetNum = value;
            }
            get
            {
                return addressStreetNum;
            }
        }

    }
}
