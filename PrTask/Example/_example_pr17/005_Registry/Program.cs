using System;
using Microsoft.Win32;

// Редактирование реестра.

namespace RegistryBasics
{
    class Program
    {
        static void Main()
        {
            RegistryKey myKey = Registry.CurrentUser;

            // Для удаления тоже нужно иметь права редактирования.
            RegistryKey wKey = myKey.OpenSubKey("Software", true);

            // Вывод на экран всего содержимого ключа поименно.
            string[] keyNameArray = wKey.GetSubKeyNames();

            foreach (string name in keyNameArray)
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                if (name.Contains("CyberBionicSystematics"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(new string(' ', 5) + name);
            }

            // Теперь пытаемся удалить ключ.
            try
            {
                Console.WriteLine("Всего записей в {0}: {1}.", wKey.Name, wKey.SubKeyCount);
                wKey.DeleteSubKey("CyberBionicSystematics");

                Console.WriteLine("Запись \'CyberBionicSystematics\' успешно удалена из реестра!");
                Console.WriteLine("Теперь записей стало: {0}.", wKey.SubKeyCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                wKey.Close();
            }

            // Задержка на экране.
            Console.ReadKey();
        }
    }
}
