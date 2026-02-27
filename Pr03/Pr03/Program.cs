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

        // Задание 2
        two:
            Console.WriteLine("Задание 2. Введите пять различных ненулевых целых чисел:");
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());
                int num4 = Convert.ToInt32(Console.ReadLine());
                int num5 = Convert.ToInt32(Console.ReadLine());

                if (num1 == 0 || num2 == 0 || num3 == 0 || num4 == 0 || num5 == 0)
                {
                    Console.WriteLine("Числа не должны быть равны нулю.");
                    goto two;
                }

                int max1 = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));
                int max2 = int.MinValue;

                if (num1 != max1)
                {
                    max2 = Math.Max(max2, num1);
                }
                if (num2 != max1)
                {
                    max2 = Math.Max(max2, num2);
                }
                if (num3 != max1)
                {
                    max2 = Math.Max(max2, num3);
                }
                if (num4 != max1)
                {
                    max2 = Math.Max(max2, num4);
                }
                if (num5 != max1)
                {
                    max2 = Math.Max(max2, num5);
                }
                if (max2 == int.MinValue)
                {
                    max2 = max1;
                }

                int prod = max1 * max2;
                Console.WriteLine($"Произведение двух наибольших чисел: {prod}");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto two;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto two;
            }

        //Задание 3
            Console.WriteLine("Задание 3.");
            int[] array1 = new int[25];
            Random randNum1 = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randNum1.Next(1, 100);
            }

            Console.WriteLine("\nСгенерированные элементы массива:");
            Console.WriteLine(string.Join(" ", array1));

            int min1 = array1.Min();
            int max3 = array1.Max();

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == min1)
                {
                    array1[i] = max3;
                }
                else if (array1[i] == max3)
                {
                    array1[i] = min1;
                }
            }
            Console.WriteLine("Массив после замены минимальных и максимальных значений:");
            Console.WriteLine(string.Join(" ", array1));

        // Задание 4
        four:
            Console.WriteLine("Задание 4.");
            try
            {
                int[] array2 = new int[25];
                Random randNum2 = new Random();

                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = randNum2.Next(1, 100);
                }

                Console.WriteLine("Сгенерированные элементы массива:");
                Console.WriteLine(string.Join(" ", array2));
                Console.Write("Введите значение K (1 < K <= L <= 25): ");

                int K = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите значение L (1 < K <= L <= 25): ");

                int L = Convert.ToInt32(Console.ReadLine());

                if (K <= 1 || L > 25 || K > L)
                {
                    Console.WriteLine("Значения K и L должны удовлетворять условию 1 < K <= L <= 25.");
                }

                int sum = 0;

                for (int i = 0; i < array2.Length; i++)
                {
                    if (i < K - 1 || i > L - 1)
                    {
                        sum += array2[i];
                    }
                }

                Console.WriteLine($"Сумма всех массива, кроме элементов с номерами от {K} до {L} включительно, равна: {sum}");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto four;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto four;
            }

        // Задание 5
        five:
            Console.WriteLine("Задание 5.");
            try
            {
                Console.Write("Введите количество дней в диапазоне от 1 до 31: ");
                int N = Convert.ToInt32(Console.ReadLine());

                if (N <= 0 || N > 31)
                {
                    Console.WriteLine("Количество дней должно быть в диапазоне от 1 до 31.");
                    goto four;
                }
                double[] array3 = new double[N];
                Random randNum3 = new Random();

                for (int i = 0; i < N; i++)
                {
                    array3[i] = Math.Round(randNum3.NextDouble() * 100, 2);
                }

                Console.WriteLine("Осадки за каждый день месяца:");

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"День {i + 1}: {array3[i]} мм");
                }

                double even = 0;
                double odd = 0;

                for (int i = 0; i < N; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        even += array3[i]; // четное
                    }
                    else
                    {
                        odd += array3[i]; //нечетное
                    }
                }
                Console.WriteLine($"Сумма осадков по четным дням: {even} мм");
                Console.WriteLine($"Сумма осадков по нечетным дням: {odd} мм");
                if (even > odd)
                {
                    Console.WriteLine("По четным числам выпало больше осадков.");
                }
                else
                {
                    Console.WriteLine("По нечетным числам выпало больше осадков.");
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto five;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto five;
            }

            Console.ReadKey();
        }
    }
}
