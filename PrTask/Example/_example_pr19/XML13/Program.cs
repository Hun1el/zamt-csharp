using System;
using System.Xml;

// Запись в XML файл со специальным форматированием.

namespace XML
{
    class Program
    {
        static void Main()
        {
            var xmlWriter = new XmlTextWriter("books.xml", null)
                                {
                                    Formatting = Formatting.Indented,
                                    IndentChar = '\t',
                                    Indentation = 1,
                                    QuoteChar = '\''
                                };

            // Включить форматирование документа (с отступом).

            // Для выделения уровня элемента использовать табуляцию.
            // использовать один символ табуляции.

            // Аналогично можно указать выравнивание с помощью четырех пробелов.
            xmlWriter.IndentChar = ' ';
            xmlWriter.Indentation = 4;

            // По умолчанию строки в XML файл записываются с помощью двойных кавычек.
            // Использование одиночных кавычек производится так:

            xmlWriter.WriteStartDocument(); 

            xmlWriter.WriteStartElement("ListOfBooks");
            xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test");
            xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

            xmlWriter.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
