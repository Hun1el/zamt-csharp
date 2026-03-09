using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Использование переменного числа аргументов

namespace example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Min ob = new Min();
            int min;
            int a = 10, b = 20;

            // Вызвать метод с двумя значениями.
            min = ob.MinVal(a, b);
            Console.WriteLine("Наименьшее значение равно " + min);

            // Вызвать метод с тремя значениями.
            min = ob.MinVal(a, b, -1);
            Console.WriteLine("Наименьшее значение равно " + min);

            // Вызвать метод с пятью значениями.
            min = ob.MinVal(18, 23, 3, 14, 25);
            Console.WriteLine("Наименьшее значение равно " + min);

            // Вызвать метод с массивом целых значений.
            int[] arg = { 45, 67, 34, 9, 112, 8 };
            min = ob.MinVal(arg);
            Console.WriteLine("Наименьшее значение равно " + min);

            // первое но... нельзя смешивать типы данных - ошибка!
            //min = ob.MinVal(1, 2.2); // Неверно!

            // второе но... параметр типа params может принимать любое число аргументов — даже нулевое!
            min = ob.MinVal(); // нет аргументов
            Console.WriteLine("Наименьшее значение равно " + min);
        }
    }
}
