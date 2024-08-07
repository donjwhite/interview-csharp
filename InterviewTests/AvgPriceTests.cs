using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tests
{
    [TestClass()]
    public class AvgPriceTests
    {
        [TestMethod()]
        public void getAveragePriceTest()
        {
            Assert.AreEqual(0.0, AvgPrice.getAveragePrice([new Trade(0, 0.0)]), 0.001);
        }
    }
}