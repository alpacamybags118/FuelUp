using System;
using NUnit.Framework;

namespace FuelUp.Tests
{
    [TestFixture]
    public class FuelUpTests
    {
        [TestCase]
        public void ThisIsARealTest()
        {
            Assert.IsTrue(true);
        }

        [TestCase]
        public void ISwearThisOneIsRealToo()
        {
            int sum;

            sum = 1 + 1;

            Assert.AreEqual(2, sum);
        }
    }
}
