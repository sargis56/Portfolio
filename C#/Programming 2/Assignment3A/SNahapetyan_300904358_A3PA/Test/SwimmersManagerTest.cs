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
    public class SwimmersManagerTest
    {
        [TestMethod]
        public void CheckIfSwimmerIsAddedInSwimManager()
        {
            SwimmersManager sut = new SwimmersManager(new ClubsManager());

            int registNum = 5435;
            string clubRegistNum = "5435d35";
            String name = "Joe Jr II";
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
            Assert.AreEqual(1, sut.NumberOfSwimmers);
        }

        [TestMethod]
        public void ShouldReturnSwimmer()
        {
            SwimmersManager sut = new SwimmersManager(new ClubsManager());

            int registNum = 5435;
            string clubRegistNum = "5435d35";
            String name = "Joe Jr II";
            DateTime dateTime = new DateTime(1970, 1, 1);
            Address address = new Address("25 Elm St", "Toronto", "ON", "T5T 5T5");
            UInt32 phoneNumber = 8888888;

            Registrant endResult = new Registrant(registNum, name, dateTime, address, phoneNumber, clubRegistNum);
            sut.AddSwimmer(endResult);

            sut.GetSwimmer(5435);

            Assert.AreEqual(endResult, sut.GetSwimmer(5435));
        }
    }
}
