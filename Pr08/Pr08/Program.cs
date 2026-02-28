// ВАРИАНТ № А17/Б10
// 1. Даны ненулевые числа x, y. Проверить истинность высказывания: «Точка с координатами(x, y) лежит в четвертой координатной четверти».
// 2. В вещественном массиве известны данные о количестве осадков, выпавших за каждый день месяца N (N - любой месяц в году). Найти общее число осадков, выпавших по нечетным числам этого месяца. Предоставить возможность пользователю реализовать заполнение элементов массива случайными (рандомными) числами.
// 3. Вводится строка. Длина строки может быть разной. Подсчитать количество содержащихся в ней строчных букв латинского алфавита.
// 4. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Подсчитать количество содержащихся в строке согласных букв.
// 5. Написать функцию int TimeToSec(H, M, S) целого типа, которая возвращает общее количество прошедших секунд исходя из 3-х своих аргументов (H - часы, M -минуты, S -секунды).
// 6. Написать функцию int SumRange(A, B) целого типа, находящую сумму всех целых чисел от A до B включительно (A и B — целые положительные). Если A > B, то функция должна возвращать число 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу: \n1 - Задание 1 \n2 - Задание 2 \n3 - Задание 3 \n4 - Задание 4 \n5 - Задание 5 \n0 - Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    // Задание 1
                    case "1":
                    one:
                        try
                        {
                            Console.WriteLine("Задание 1. Даны ненулевые числа x, y. Проверить истинность высказывания.");
                            Console.WriteLine("Введите ненулевые числа x и y:");

                            Console.Write("Введите x: ");
                            int x = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите y: ");
                            int y = Convert.ToInt32(Console.ReadLine());

                            bool result1 = First(x, y);

                            if (result1)
                            {
                                Console.WriteLine("Точка лежит в четвертой четверти.");
                            }
                            else
                            {
                                Console.WriteLine("Точка не лежит в четвертой четверти.");
                            }
                            break;
                        }
                        catch (FormatException ex1)
                        {
                            Console.WriteLine(ex1.Message);
                            goto one;
                        }
                        catch (OverflowException ex2)
                        {
                            Console.WriteLine(ex2.Message);
                            goto one;
                        }
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static bool First(int x, int y)
        {
            return x > 0 && y < 0;
        }

        static double Two()
        {
            double total = 0;
            int month = Convert.ToInt32(Console.ReadLine());
            double[] arraymonth;
            int days = 0;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 9 || month == 12)
            {
                days = 31;
            }
            else if (month == 4 || month == 6 || month == 10 || month == 11)
            {
                days = 30;
            }
            else if (month == 2)
            {
                days = 28;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
                return 0;
            }

            arraymonth = new double[days];
            Random random = new Random();

            for (int i = 0; i < arraymonth.Length; i++)
            {
                arraymonth[i] = random.Next(0, 50) + random.NextDouble();
                Console.WriteLine($"День {i + 1}: {Math.Round(arraymonth[i], 2)} мм");
            }

            for (int i = 0; i < days; i += 2)
            {
                total += arraymonth[i];
            }

            return total;
        }
    }
}
