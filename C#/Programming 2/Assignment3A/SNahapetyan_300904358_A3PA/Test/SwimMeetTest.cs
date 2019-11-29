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
    public class SwimMeetTest
    {
        [TestMethod]
        public void CheckIfEventIsAdded()
        {
            SwimMeet sut = new SwimMeet();
            Event eventHeld = new Event(EventDistance._100, Stroke.Backstroke);
            sut.AddEvent(eventHeld);

            Assert.AreEqual(EventDistance._100, sut.Events[0].Distance);
            Assert.AreEqual(Stroke.Backstroke, sut.Events[0].Stroke);
            Assert.AreEqual(0, sut.Events[0].SwimmerArrayNum);
        }

        [TestMethod]
        public void CheckIfSwimMeetIsSeeded()
        {
            SwimMeet sut = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.LCM, 2);
            Event eventHeld = new Event(EventDistance._100, Stroke.Backstroke);
            sut.AddEvent(eventHeld);
            sut.Seed();
            Assert.AreEqual(EventDistance._100, sut.CurrentEvent.Distance);
            Assert.AreEqual(Stroke.Backstroke, sut.CurrentEvent.Stroke);
        }

        [TestMethod]
        public void ShouldReturnSwimMeetInfo()
        {
            SwimMeet sut = new SwimMeet();
            string result;
            string eventString = "";
            string endResult = string.Format("Sweem meet name: {0}\nFrom-to: {1} to {2}\nPool type: {3}\nNo lanes: {4}\nEvents: {5}", sut.Name, sut.StartDate.ToString("yyyy-MM-dd"), sut.EndDate.ToString("yyyy-MM-dd"), sut.APoolType, sut.NoOfLanes, eventString);
            result = sut.GetInfo();
            Assert.AreEqual(endResult, result);
        }
    }
}
