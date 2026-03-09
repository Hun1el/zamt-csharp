using System;

//импортируем наше пространство имен
using MathLibraryKV;

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявленный класс в MathLibrary.dll
            Class1 math = new Class1();

            // вызываем методы из MathLibrary.dll
            float substract = math.Sub(5, 2);
            float multiply = math.Mul(5, 2);
            float devide = math.Dev(5, 2);
            float power = math.Pow(5);

            Console.WriteLine("Это приложение использует MathLibrary.dll");

            // выводим ответы на консоль
            Console.WriteLine(substract);
            Console.WriteLine(multiply);
            Console.WriteLine(devide);
            Console.WriteLine(power);

            Console.ReadLine();
        }
    }
}
