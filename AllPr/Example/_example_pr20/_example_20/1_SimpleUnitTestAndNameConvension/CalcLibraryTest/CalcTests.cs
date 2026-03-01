using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;

namespace CalcLibraryTest
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_10plus20_30returned()
        {
            // arrange
            double x = 10;
            double y = 20;
            double expected = 30;

            // act
            double actual = Calc.Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
