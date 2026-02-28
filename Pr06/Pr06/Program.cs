// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
//ВАРИАНТ № А17/Б10
//1. Даны ненулевые числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит в четвертой координатной четверти».
//2. Дан целочисленный массив, состоящий из N элементов (N > 0). Преобразовать массив, прибавив к четным числам первый элемент. Первый и последний элементы массива не изменять. Вывести новый полученный массив.
//3. Дан целочисленный массив, состоящий из N элементов (N > 0). Найти и вывести количество элементов, расположенных перед первым минимальным элементом.
//4. Вводится строка-предложение. Длина строки может быть разной. Подсчитать количество содержащихся в строке знаков препинания (точка, запятая, двоеточие, точка с запятой, восклицательный знак, вопросительный знак).
//5. Вводится строка, состоящая из слов разделенных точками. Длина строки может быть разной. Сформировать и вывести подстроку, расположенную между второй и пятой точками исходной строки. Если в строке менее пяти точек, то вывести всю исходную строку.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Задание 1
            Console.WriteLine("Задание 1. Даны ненулевые числа x, y. Проверить истинность высказывания.");
        one:
            try
            {
                Console.WriteLine("Введите два ненулевых числа x и y");

                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                if (x > 0 && y < 0)
                {
                    Console.WriteLine($"Точка с координатами ({x};{y}) лежит в четвертой координатной четверти: True\n");
                }
                else
                {
                    Console.WriteLine($"Точка с координатами ({x};{y}) НЕ лежит в четвертой координатной четверти: False");
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

        //Задание 2
        two:
            try
            {
                Console.WriteLine("\nЗадание 2. Дан целочисленный массив (N > 0). Преобразовать массив, прибавив к четным числам первый элемент.");
                Console.Write("Введите элементы массива (N > 0): ");

                int N1 = Convert.ToInt32(Console.ReadLine());

                if (N1 <= 0)
                {
                    Console.WriteLine("Массив должен быть больше 0");
                    goto two;
                }

                if (N1 < 25)
                {
                    Console.WriteLine("Массив должен быть не менее 25 элементов.");
                    goto two;
                }

                int[] array1 = new int[N1];
                Random randNum1 = new Random();

                for (int i = 0; i < N1; i++)
                {
                    array1[i] = randNum1.Next(0, 100);
                }

                Console.WriteLine("Сгенерированный массив: ");
                Console.WriteLine(string.Join(" ", array1));

                int elem = array1[0];

                for (int i = 1; i < N1 - 1; i++)
                {
                    if (array1[i] % 2 == 0)
                    {
                        array1[i] += elem;
                    }
                }

                Console.WriteLine("Полученный массив: ");
                Console.WriteLine(string.Join(" ", array1));
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
        three:
            try
            {
                Console.WriteLine("\nЗадание 3. Дан целочисленный массив (N > 0). Вывести количество элементов, перед первым минимальным элементом.");
                Console.Write("Введите размер массива N (N > 0): ");

                int N2 = Convert.ToInt32(Console.ReadLine());

                if (N2 < 25)
                {
                    Console.WriteLine("Массив должен быть не менее 25 элементов.");
                    goto three;
                }

                int[] array2 = new int[N2];
                Random randNum2 = new Random();

                for (int i = 0; i < N2; i++)
                {
                    array2[i] = randNum2.Next(0, 100);
                }

                Console.WriteLine("Сгенерированный массив: ");
                Console.WriteLine(string.Join(" ", array2));

                int minvalue = array2[0];
                int mini = 0;

                for (int i = 1; i < N2; i++)
                {
                    if (array2[i] < minvalue)
                    {
                        minvalue = array2[i];
                        mini = i;
                    }
                }

                Console.WriteLine($"Количество элементов перед первым минимальным элементом: {mini}");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto three;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto three;
            }

            Console.ReadKey();
        }
    }
}
