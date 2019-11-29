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
    public class ClubsManagerTest
    {
        [TestMethod]
        public void CheckIfClubIsAdded()
        {
            ClubsManager sut = new ClubsManager();

            uint clubRegistNum = 5435;
            String name = "CCAC";
            Address address = new Address("35 River St", "Toronto", "ON", "M2M 5M5");
            UInt32 phoneNumber = 4165555555;

            sut.Add(new Club(clubRegistNum, name, address, phoneNumber));

            Assert.AreEqual(clubRegistNum, sut.Clubs[0].ClubRegistNum);
            Assert.AreEqual(name, sut.Clubs[0].Name);
            Assert.AreEqual(address, sut.Clubs[0].ClubAddress);
            Assert.AreEqual(phoneNumber, sut.Clubs[0].PhoneNumber);
            //Assert.AreEqual(1, sut.NumberOfClubs);
        }

        [TestMethod]
        public void ShouldReturnClub()
        {
            ClubsManager sut = new ClubsManager();

            uint clubRegistNum = 5435;
            String name = "CCAC";
            Address address = new Address("35 River St", "Toronto", "ON", "M2M 5M5");
            UInt32 phoneNumber = 4165555555;
            Club endResult = new Club(clubRegistNum, name, address, phoneNumber);
            sut.Add(endResult);

            Assert.AreEqual(endResult, sut.GetByRegNum(5435));
        }
    }
}
