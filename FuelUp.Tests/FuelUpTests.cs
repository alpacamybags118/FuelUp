using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuelUp.Tests
{
    [TestClass]
    public class FuelUpTests
    {
        [TestMethod]
        public void ThisIsARealTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ISwearThisOneIsRealToo()
        {
            int sum;

            sum = 1 + 1;

            Assert.AreEqual(2, sum);
        }
    }
}
