using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AssertSamples.Tests
{
    [TestClass]
    public class CollectionAssertMethods
    {
        static List<string> employees;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            employees = new List<string>();

            employees.Add("Ivan");
            employees.Add("Sergey");
            employees.Add("Anton");
            employees.Add("Roman");
        }
        

        [TestMethod]
        public void AllItemsAreNotNull()
        {
            // Проверка, что все элементы коллекции созданы
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            // Проверка значений коллекции на уникальность
            CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
        }

        [TestMethod]
        public void AreEqual()
        {
            List<string> employeesTest = new List<string>();

            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            // Проверка каждого элемента на равенство, в данном примере первый элемент из коллекции emploees
            // не совпадает с первым элементом из коллекции emploeesTest. Тест не пройдет.
            CollectionAssert.AreEqual(employees, employeesTest);
        }

        [TestMethod]
        public void AreEquivalent()
        {

            List<string> employeesTest = new List<string>();

            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            // Проверка коллекций на наличие одинаковых элементов, порядок которых не важен.
            CollectionAssert.AreEquivalent(employees, employeesTest);
        }

        [TestMethod]
        public void employees_Subset()
        {
            List<string> employees_Subset = new List<string>();

            employees_Subset.Add(employees[2]);
            employees_Subset.Add("Alexander"); // Если убрать комментарий - тест не пройдет

            // Проверка того, что элементы employees_Subset входят в коллекцию employees.
            CollectionAssert.IsSubsetOf(employees_Subset, employees, "failed!");
        }
    }
}