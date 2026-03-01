using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace AssertSamples.Tests
{
    [TestClass]
    public class ExpectingExceptions
    {
        // ExpectedException -  тест будет успешным если в процессе выполнения будет выброшено исключение с типом ArgumentNullException
        [ExpectedException(typeof(ArgumentNullException), "Exception was not thrown")]
        [TestMethod]
        public void MyClass_SayHello_Exception()
        {
            MyClass instance = new MyClass();
            instance.SayHello(null);
        }

        [TestMethod]
        public void MyClass_SayHello_ReturnDmitriy()
        {
            // arrange
            MyClass instance = new MyClass();
            string expected = "Hello Dmitriy";

            // act
            string actual = instance.SayHello("Dmitriy");
            
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}