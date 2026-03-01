using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertSamples.Tests
{
    [TestClass]
    public class MyClassTests
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            // arrange
            const double input = 4;
            const double expected = 2;

            // act
            double actual = MyClass.GetSqrt(input);

            // assert
            Assert.AreEqual(expected, actual, "Sqrt of {0} should have been {1}!", input, expected);
        }

        [TestMethod]
        public void DeltaTest()
        {
            const double expected = 3.1;
            const double delta = 0.07;

            // 3.1622776601683795
            // 0.062..
            double actual = MyClass.GetSqrt(10);

            // Проверка значений на равенство с учетом погрешности delta
            Assert.AreEqual(expected, actual, delta, "fail message!!!");
        }

        [TestMethod]
        public void StringAreEqualTest()
        {
            // arrange
            const string input = "HELLO";
            const string expected = "hello";

            // act and assert
            // третий параметр - игнорирование регистра
            Assert.AreEqual(expected, input, true);
        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = "Hello";

            // проверка равенства ссылок
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void IntegersSameTest()
        {
            int i = 10;
            int j = 10;

            // проверка равенства ссылок
            Assert.AreSame(i, j);
        }
    }
}