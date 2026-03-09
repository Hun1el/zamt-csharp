using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using var17;

namespace Pr20Test
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Test1()
        {
            double A = 1;
            double B = -3;
            double C = 2;
            int expected = 2;

            int actual = Task05.RootCount(A, B, C);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            double A = 1;
            double B = -2;
            double C = 1;
            int expected = 1;

            int actual = Task05.RootCount(A, B, C);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test3()
        {
            double A = 1;
            double B = 1;
            double C = 1;
            int expected = 0;

            int actual = Task05.RootCount(A, B, C);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test4()
        {
            double A = 0;
            double B = 1;
            double C = 1;
            bool excep = false;

            try
            {
                Task05.RootCount(A, B, C);
            }
            catch (ArgumentException exception)
            {
                excep = true;
                Assert.AreEqual("A не может быть = 0", exception.Message);
            }
            Assert.IsTrue(excep);
        }
    }
}
