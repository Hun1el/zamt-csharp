using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using var17;

namespace Pr20Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test1()
        {
            int number = 123;
            int[] expected = { 123, 132, 213, 231, 312, 321 };

            int[] actual = Task02.Number(number);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            {
                int number = 1000;
                bool excep = false;
                try
                {
                    Task02.Number(number);
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    excep = true;
                    Assert.AreEqual("Число должно быть трехзначным.", exception.ParamName);
                }

                Assert.IsTrue(excep, "Всё хорошо");
            }
        }
        [TestMethod]
        public void Test3()
        {
            int number = 111;
            int[] expected = { 111, 111, 111, 111, 111, 111 };

            int[] actual = Task02.Number(number);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void Test4()
        {
            int number = 0;
            bool excep = false;

            try
            {
                Task02.Number(number);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                excep = true;
                Assert.AreEqual("Число должно быть трехзначным.", ex.ParamName);
            }
            Assert.IsTrue(excep, "Всё хорошо");
        }
    }
}
