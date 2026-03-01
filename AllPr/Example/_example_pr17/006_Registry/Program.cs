using System;
using Microsoft.Win32;

// Редактирование реестра.

namespace RegistryBasics
{
	class Program
	{
		static void Main()
		{
			// Совершаем навигацию в нужное место и открываем его для записи.
			RegistryKey myKey = Registry.CurrentUser;
			RegistryKey wKey = myKey.OpenSubKey("Software", true);
			RegistryKey newKey = wKey.CreateSubKey("CyberBionicSystematics");

			// Совершаем запись в реестр.
			newKey.SetValue("TheStringName", "I contain string value.");
			newKey.SetValue("TheInt32Name", 1234567890);
             
			// Тип можно указать явно.
			newKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

			wKey.Close();
			newKey.Close();

			// Задержка на экране.
			// Console.ReadKey();
		}
	}
}
