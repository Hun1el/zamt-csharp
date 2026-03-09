using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using var17;

namespace Pr20Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Test1()
        {
            int number = 123;
            string expected = "173";

            string actual = Task04.DecToOct(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            int number = 255;
            string expected = "377";

            string actual = Task04.DecToOct(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test3()
        {
            int number = 999;
            string expected = "1757";

            string actual = Task04.DecToOct(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            int number = -500;
            string expected = "0";

            string actual = Task04.DecToOct(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
