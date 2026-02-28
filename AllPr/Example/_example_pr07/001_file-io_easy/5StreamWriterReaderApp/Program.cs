using System;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Работа с StreamWriter / StreamReader *****\n");

            // получаем объект StreamWriter и записываем строковые данные
            using (StreamWriter writer = File.CreateText("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                    writer.Write(i + " ");

                // вставляем новую строку
                writer.Write(writer.NewLine);
            }

            // читаем из файла
            Console.WriteLine("Что мы прочитали из файла:\n");
            using (StreamReader sr = File.OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();
        }
    }
}