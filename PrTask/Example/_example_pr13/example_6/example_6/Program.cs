using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Статические классы
// Во-первых, объекты статического класса создавать нельзя.
// во-вторых, статический класс должен содержать только статические члены. 

namespace example_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обратная величина числа 5 равна " + NumericFn.Reciprocal(5.0));
            Console.WriteLine("Дробная часть числа 4.234 равна " + NumericFn.FracPart(4.234));

            if (NumericFn.IsEven(10))
                Console.WriteLine("10 — четное число.");

            if (NumericFn.IsOdd(5))
                Console.WriteLine("5 — нечетное число.");

            // Далее следует попытка создать экземпляр объекта класса NumericFn,
            // что может стать причиной появления ошибки.
            //NumericFn ob = new NumericFn(); // Ошибка!

        }
    }
}
