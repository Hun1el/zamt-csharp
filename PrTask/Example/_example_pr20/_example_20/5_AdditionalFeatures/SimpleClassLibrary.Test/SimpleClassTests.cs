using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary.Tests
{
    // Ordered Tests содержит другие Unit тесты, которые должны быть запущены в определенном порядке.
    // Ordered Test отображается как отдельный тест в Test Explorer Window
    // Для создания Ordered Test сделайте правый клик по проекту и в контекстном меню выберите Add -> Ordered Test
    [TestClass()]
    public class SimpleClassTests
    {
        [TestMethod()]
        public void Add_2_3_Returns_5()
        {
            SimpleClass instance = new SimpleClass();
            int x = 2, y = 3, expected = 5;

            int actual = instance.Add(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Div_10_2_Returns_5()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 2, expected = 5;

            int actual = instance.Div(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_10_0_ExceptionExpected()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 0;

            int actual = instance.Div(x, y);
        }
    }
}