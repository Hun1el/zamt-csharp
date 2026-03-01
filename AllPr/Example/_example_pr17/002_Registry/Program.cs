using System;
using Microsoft.Win32;

// Навигация по реестру.

namespace RegistryBasics
{
    class Program
    {
        static void Main()
        {
            // Процесс получения ссылки на объект RegistryKey называется открытием ключа.
            RegistryKey myKey = Registry.LocalMachine;
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");
           // software.Close();

            Console.WriteLine("{0} - всего элементов: {1}.", microsoft.Name, microsoft.SubKeyCount);
            microsoft.Close();
            Console.WriteLine("");

            // Попытка открыть несуществующий ключ. Переменной будет присвоено значение NULL.
            Console.WriteLine("Открываем несуществующий ключ");
            software = myKey.OpenSubKey("StrangeName");
            Console.WriteLine("");

            // В блоке try совершается попытка обратится к переменной, значение которой не присвоено.
            try
            {
                Console.WriteLine("Попытка обратится к переменной, значение которой не присвоено");
                Console.WriteLine("Открыли узел: {0}.", software.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            // Задержка на экране.
            Console.ReadKey();
        }
    }
}
