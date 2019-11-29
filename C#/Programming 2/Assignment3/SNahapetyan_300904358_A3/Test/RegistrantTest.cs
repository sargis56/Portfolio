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
    public class RegistrantTest
    {
        [TestMethod]
        public void ShouldReturnRegistrantInfo()
        {
            Registrant sut = new Registrant(23424, "Bob Smith", new DateTime(1970, 1, 1), new Address("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567, "312312");
            string result;
            if (sut.Club == null)
            {
                sut.ClubName = "not assigned";
            }
            else
            {
                sut.ClubName = sut.Club.Name;
            }
            string endResult = string.Format("Name: {0}\nAdress: \n   {1}\n   {2}\n   {3}\n   {4}\nPhone: {5}\nDOB: {6}\nReg number: {7}\nClub: {8}", sut.Name, sut.Address.AddressStreet, sut.Address.City, sut.Address.Province, sut.Address.Postal, sut.PhoneNumber, sut.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt"), sut.RegistNum, sut.ClubName);
            result = sut.GetInfo();
            Assert.AreEqual(endResult, result);
        }
    }
}
