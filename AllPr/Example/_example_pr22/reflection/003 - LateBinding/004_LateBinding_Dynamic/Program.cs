using System;
using System.IO;
using System.Reflection;

// Создаем объект выбранного нами типа "на лету".

// Позднее связывание - это технология которая позволяет обнаруживать типы,
// определять их имена и члены непосредственно в процессе выполнения.

// Раннее связывание - все указанные выше операции выполняются во время компиляции.

namespace _004_LateBinding_Dynamic
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
                Type type = assembly.GetType("CarLibrary.MiniVan");
            
                dynamic carInstance = Activator.CreateInstance(type);
                carInstance.Acceleration();
                carInstance.Driver("Shumaher", 26);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }


            // Задержка.
            Console.ReadKey();
        }
    }
}
