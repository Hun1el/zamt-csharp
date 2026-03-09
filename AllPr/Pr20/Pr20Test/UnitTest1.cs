using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using var17;

namespace Pr20Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            int x = 5;
            int y = 5;
            bool expected = true;

            bool actual = Task01.FirstOrThree(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()
        {
            int x = -3;
            int y = -7;
            bool expected = true;

            bool actual = Task01.FirstOrThree(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            int x = 4;
            int y = -2;
            bool expected = false;

            bool actual = Task01.FirstOrThree(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            int x = 0;
            int y = 5;
            bool expected = false;

            bool actual = Task01.FirstOrThree(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
