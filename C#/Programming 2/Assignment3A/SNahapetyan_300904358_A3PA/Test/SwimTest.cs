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
    public class SwimTest
    {
        [TestMethod]
        public void ShouldReturnSwimInfo()
        {
            Swim sut = new Swim(null, 45, 65);
            string result;
            string endResult = string.Format("\n\tH{0}L{1}\t time: no time\n", sut.HeatNum, sut.LaneNum);
            result = sut.GetInfo();
            Assert.AreEqual(endResult, result);
        }
    }
}
