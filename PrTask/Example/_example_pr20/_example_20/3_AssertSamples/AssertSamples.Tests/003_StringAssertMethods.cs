using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AssertSamples.Tests
{
    [TestClass]
    public class StringAssertMethods
    {
        [TestMethod]
        public void StringContainsTest()
        {
            // Проверка на вхождение в строку подстроки
            StringAssert.Contains("Assert samples", "sam");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
            // Проверка с использованием регулярного выражения
            StringAssert.Matches("123", new Regex(@"\d{3}"));
        }


        [TestMethod]
        public void StringStartsWithTest()
        {
            // Проверка того, что строка начинается с определенного слова
            StringAssert.StartsWith("Hello world", "Hello");
        }

        [TestMethod]
        public void StringEndsWithTest()
        {
            // Проверка того, что строка заканчивается определенным словом
            StringAssert.EndsWith("Hello world", "world");
        }
    }
}