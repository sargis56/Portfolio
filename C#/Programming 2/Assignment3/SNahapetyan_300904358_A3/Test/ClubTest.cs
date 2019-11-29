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
    public class ClubTest
    {
        [TestMethod]
        public void CheckIfSwimmerIsAddedInClubClass()
        {
            Club sut = new Club();

            int registNum = 5435;
            string clubRegistNum = "5435d35";
            String name = "Joe Jr";
            DateTime dateTime = new DateTime(1970, 1, 1);
            Address address = new Address("25 Elm St", "Toronto", "ON", "T5T 5T5");
            UInt32 phoneNumber = 8888888;

            sut.AddSwimmer(new Registrant(registNum, name, dateTime, address, phoneNumber, clubRegistNum));

            Assert.AreEqual(registNum, sut.Swimmers[0].RegistNum);
            Assert.AreEqual(clubRegistNum, sut.Swimmers[0].ClubRegNumber);
            Assert.AreEqual(name, sut.Swimmers[0].Name);
            Assert.AreEqual(dateTime, sut.Swimmers[0].DateOfBirth);
            Assert.AreEqual(address, sut.Swimmers[0].Address);
            Assert.AreEqual(phoneNumber, sut.Swimmers[0].PhoneNumber);
            Assert.AreEqual(1, sut.Swimmers.Count);
        }

        [TestMethod]
        public void ShouldReturnClubInfo()
        {
            Club sut = new Club();
            string result;
            string eventString = "\n\t";
            string endResult = string.Format("Name: {0}\nAdress:\n   {1}\n   {2}\n   {3}\n   {4}\nPhone: {5}\nReg number: \nSwimmers: {6}", sut.Name, sut.ClubAddress.AddressStreet, sut.ClubAddress.City, sut.ClubAddress.Province, sut.ClubAddress.Postal, sut.PhoneNumber, eventString);
            result = sut.GetInfo();
            Assert.AreEqual(endResult, result);
        }
    }
}
