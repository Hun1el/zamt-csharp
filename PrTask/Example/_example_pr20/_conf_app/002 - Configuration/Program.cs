using System;
using System.Configuration;
using System.Collections.Specialized;

namespace ConfigurationBasic
{
    class Program
    {
        static void Main()
        {
            // 1 (Устарел)
            string value = ConfigurationSettings.AppSettings["Foo"];
            Console.WriteLine(value);

            Console.WriteLine(new string('-', 12));

            // 2
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;

            Console.WriteLine(allAppSettings["Foo"]);
            Console.WriteLine(allAppSettings[0]);

            Console.WriteLine(new string('-', 12));

            // 3
            for (int i = 0; i < allAppSettings.Count; i++)
            {
                Console.WriteLine(allAppSettings[i]);
            }

            Console.WriteLine(new string('-', 12));

            // 4
            foreach (string item in allAppSettings)
            {
                Console.WriteLine(allAppSettings[item]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
