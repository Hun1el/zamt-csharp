using System;

// Используем типы из CarLibrary.
using CarLibrary;

// Использование собственной библиотеки кода.

namespace CSharpCarClient
{
    class Program
    {
        public static void Main()
        {
            // Создаем автомобиль спортивной модели.
            SportsCar sportcar = new SportsCar("Viper", 240, 40);
            sportcar.Acceleration();

            // Создаем мини-вэн.
            MiniVan minivan = new MiniVan();
            minivan.Acceleration();

            // Задержка.
            Console.ReadKey();            
        }
    }
}
