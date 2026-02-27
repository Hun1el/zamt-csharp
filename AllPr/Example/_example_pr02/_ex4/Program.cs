using System;

namespace _ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // обработка сразу нескольких исключений
            // Здесь массив numer длиннее массива denom.
            int[] number = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };

            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    Console.WriteLine(number[i] + " / " +
                                    denom[i] + " равно " +
                                    number[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на нуль нельзя!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Подходящий элемент не найден.");
                }
            }
        }
    }
}