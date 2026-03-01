using System;
using Microsoft.Win32;

namespace RegistryBasics
{
	class Program
	{
		static void Main()
		{
			// Совершаем навигацию по реестру и открываем ключ для чтения,
			// можно сразу указать весь путь, а не совершать навигацию поэтапно.
			RegistryKey myKey = Registry.CurrentUser;
			RegistryKey wKey = myKey.OpenSubKey(@"Software\CyberBionicSystematics"); 

			// Читаем данные и конвертируем в нужный формат.
			string Str = wKey.GetValue("TheStringName") as string;
			int Int = Convert.ToInt32(wKey.GetValue("TheInt32Name"));
			int Ant = Convert.ToInt32(wKey.GetValue("AnotherName"));

			wKey.Close();

			// Покажем содержимое, чтобы убедиться в том, что чтение прошло успешно.
			Console.WriteLine("String: {0}\nInt32: {1}\nAnother: {2}", Str, Int, Ant);

			// Задержка.
			Console.ReadKey();
		}
	}
}
