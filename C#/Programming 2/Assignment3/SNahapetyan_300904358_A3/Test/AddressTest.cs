using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void CheckIfAddressIsAdded()
        {
            String street = "35 Elm St";
            String city = "Toronto";
            String province = "on";
            String postal = "M2M 2M2";

            Address address = new Address(street, city, province, postal);
            Assert.AreEqual(street, address.AddressStreet);
            Assert.AreEqual(city, address.City);
            Assert.AreEqual(province, address.Province);
            Assert.AreEqual(postal, address.Postal);
        }
    }
}
