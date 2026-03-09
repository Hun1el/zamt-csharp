using System;
using System.IO;
using System.Xml;

// Загрузка содержимого XML из файла.

namespace XML
{
	class Program
	{
		static void Main()
		{
			Console.SetWindowSize(80, 45);

			FileStream stream = new FileStream("books.xml", FileMode.Open);

			XmlTextReader xmlReader = new XmlTextReader(stream);

			while (xmlReader.Read())
			{
				Console.WriteLine("{0,-10} {1,-10} {2,-10}",
					xmlReader.NodeType,
					xmlReader.Name,
					xmlReader.Value);
			}

			xmlReader.Close();
			//stream.Close();

			// Delay.
			Console.ReadKey();
		}
	}
}
