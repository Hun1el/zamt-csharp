using System;
using System.Xml;
using System.Xml.XPath;

// Выборка из XML с помощью XPath. (Запросы XPath)

namespace XML
{
    class Program
    {
        static void Main()
        {
            // Создание XPath документа.
            var document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath.
            XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/Book/Title");
            while (iterator1.MoveNext())
            {
                Console.WriteLine(iterator1.Current);
            }
            Console.WriteLine(new string('-',20));
            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("ListOfBooks/Book[2]/Price");
            XPathNodeIterator iterator2 = navigator.Select(expr);

            while (iterator2.MoveNext())
            {
                Console.WriteLine(iterator2.Current);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
