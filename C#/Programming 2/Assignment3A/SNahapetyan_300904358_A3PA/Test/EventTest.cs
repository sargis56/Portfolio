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
    public class EventTest
    {
        [TestMethod]
        public void CheckIfSwimmerIsAddedInEventClass()
        {
            Event sut = new Event(EventDistance._100, Stroke.Backstroke);

            String name = "Joe";
            DateTime dateTime = new DateTime(1970, 1, 1);
            Address address = new Address("35 Elm St", "Toronto", "ON", "M2M 2M2");
            UInt32 phoneNumber = 999999;

            sut.AddSwimmer(new Registrant(name, dateTime, address, phoneNumber));

            Assert.AreEqual(name, sut.Swimmers[0].Name);
            Assert.AreEqual(dateTime, sut.Swimmers[0].DateOfBirth);
            Assert.AreEqual(address, sut.Swimmers[0].Address);
            Assert.AreEqual(phoneNumber, sut.Swimmers[0].PhoneNumber);
            Assert.AreEqual(1, sut.SwimmerArrayNum);
        }

        [TestMethod]
        public void ShouldReturnSeededSwimmerHeatAndLane()
        {
            int noOfLanes = 5;
            Event sut = new Event(EventDistance._100, Stroke.Backstroke);

            String name = "Joe";
            DateTime dateTime = new DateTime(1970, 1, 1);
            Address address = new Address("35 Elm St", "Toronto", "ON", "M2M 2M2");
            UInt32 phoneNumber = 999999;

            sut.AddSwimmer(new Registrant(name, dateTime, address, phoneNumber));
            sut.Seed(PoolType.SCM, noOfLanes);

            int lane = 0 % noOfLanes + 1;
            int heat = 0 / noOfLanes + 1;

            Assert.AreEqual(heat, sut.SwimArray[0].HeatNum);
            Assert.AreEqual(lane, sut.SwimArray[0].LaneNum);
        }

        [TestMethod]
        public void ShouldReturnEventInfo()
        {
            Event sut = new Event(EventDistance._100, Stroke.Backstroke);
            string result;
            string endResult = string.Format(EventDistance._100 + " " + Stroke.Backstroke + "\n");
            result = sut.GetInfo();
            Assert.AreEqual(endResult, result);
        }
    }
}
