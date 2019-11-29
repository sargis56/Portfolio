using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimLibrary
{
    public struct Address
    {

        private string street;
        private string city;
        private string province;
        private string zip;

        public Address( string street, string city, string province, string zip)
        {
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string Street
        {
            get
            {
                return street;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
        }

        public string Province
        {
            get
            {
                return province;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
        }

        public override string ToString()
        {
            return $"\n\t{Street}\n\t{City}\n\t{Province}\n\t{Zip}";
        }
    }
}
