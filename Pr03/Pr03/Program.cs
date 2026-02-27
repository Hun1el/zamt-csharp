//ВАРИАНТ № А17/Б10
//1. Проверить истинность высказывания: "Среди трех данных целых положительны чисел введенных с клавиатуры, есть хотя бы одна пара совпадающих".
//2. Ввести пять различных ненулевых целых чисел. Найти произведение двух наибольших чисел.
//3. Дан целочисленный массив, состоящий из N элементов (N > 0). Поменять местами минимальный и максимальный элемент в массиве. Вывести вначале исходный массив, а строкой ниже полученный массив после замены.
//4. Дан целочисленный массив, состоящий из N элементов и целые числа K и L (1 < K ≤ L ≤ N). Найти сумму всех элементов массива, кроме элементов с номерами от K до L включительно.
//5. В вещественном массиве известны данные о количестве осадков, выпавших за каждый день месяца N (N - любой месяц в году). Верно ли, что по четным числам выпало больше осадков, чем по нечетным? Предоставить возможность пользователю реализовать заполнение элементов массива случайными (рандомными) числами.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Задание 1
        one:
            Console.WriteLine("Задание 1. Введите три целых положительных числа:");
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 <= 0 || num2 <= 0 || num3 <= 0)
                {
                    Console.WriteLine("Ошибка ввода, числа должны быть положительными.");
                    goto one;
                }
                else
                    if (num1 == num2 || num1 == num3 || num2 == num3)
                    {
                        Console.WriteLine("Среди чисел есть хотя бы одна пара совпадающих.");
                    }
                    else
                    {
                        Console.WriteLine("Нет совпадающих чисел.");
                    }
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

            Console.ReadKey();
        }
    }
}
