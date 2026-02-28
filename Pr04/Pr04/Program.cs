// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
//ВАРИАНТ № А17/Б10
//1. Дан целочисленный массив, состоящий из N элементов (N > 0), содержащий, по крайней мере, два нуля. Вычислить сумму чисел из данного набора, расположенных между этими двумя нулями. Если нули идут подряд, то вывести 0. Если в массиве имеется только одно значение 0, то вычислить сумму всех его элементов.
//2. Дан целочисленный массив, состоящий из N элементов (N > 0). Преобразовать массив, прибавив к четным числам первый элемент. Первый и последний элементы массива не изменять. Вывести новый полученный массив.
//3. Вводится строка, состоящая из слов (разделенных знаком равенства - '='), содержащая, по крайней мере, один символ '='. Длина строки может быть разной. Вывести подстроку, расположенную между вторым и третьим знаком '=' исходной строки. Если строка содержит менее 3-х символов '=', то вывести всю строку.
//4. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Найти и вывести длину самого большого слова и вывести это слово на экран.
//5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести на экран слово/слова, которые содержат ровно три буквы 'x'.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Задание 1
        one:
            try
            {
                Console.WriteLine("Задание 1. Дан целочисленный массив (N > 0), содержащий, по крайней мере, два нуля (Если нули идут подряд - вывести 0).");
                Console.Write("Введите элементы массива (N > 0): ");

                int N = Convert.ToInt32(Console.ReadLine());
                int[] array1 = new int[N];

                if (N <= 0)
                {
                    Console.WriteLine("Массив должен быть больше 0");
                    goto one;
                }

                Console.WriteLine("Введите элементы массива: ");

                for (int i = 0; i < N; i++)
                {
                    array1[i] = int.Parse(Console.ReadLine());
                }

                int zero1 = Array.IndexOf(array1, 0);
                int zero2 = Array.LastIndexOf(array1, 0);

                if (zero1 == zero2)
                {
                    Console.WriteLine("Сумма всех элементов массива: " + array1.Sum());
                }
                else if (zero2 - zero1 == 1)
                {
                    Console.WriteLine("Нули идут подряд. Сумма: 0");
                }
                else
                {
                    int sum = 0;

                    for (int i = zero1 + 1; i < zero2; i++)
                    {
                        sum += array1[i];
                    }

                    Console.WriteLine("Сумма между двумя нулями: " + sum);
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
            try
            {
                Console.WriteLine("Задание 2. Преобразовать массив, прибавив к четным числам первый элемент массива.");
                Console.Write("Введите элементы массива (N > 0): ");

                int N = Convert.ToInt32(Console.ReadLine());

                if (N <= 0)
                {
                    Console.WriteLine("Массив должен быть больше 0");
                    goto two;
                }

                int[] array2 = new int[N];
                Random randNum1 = new Random();

                for (int i = 0; i < N; i++)
                {
                    array2[i] = randNum1.Next(0, 100);
                }

                Console.WriteLine("Сгенерированный массив: ");
                Console.WriteLine(string.Join(" ", array2));

                int elem = array2[0];

                for (int i = 1; i < N - 1; i++)
                {
                    if (array2[i] % 2 == 0)
                    {
                        array2[i] += elem;
                    }
                }

                Console.WriteLine("Полученный массив: ");
                Console.WriteLine(string.Join(" ", array2));
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

        // Задание 3
        three:
            Console.WriteLine("Задание 3. Вводится строка, состоящая из слов (разделенных знаком '='), содержащая, по крайней мере, один символ '='. ");
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            string[] mass1 = str1.Split('=');
            if (!str1.Contains('='))
            {
                Console.WriteLine("В строке должен быть хотя бы один знак '='");
                goto three;
            }
            if (mass1.Length < 4)
            {
                Console.WriteLine("Меньше трех знаков '='. Исходная строка: " + str1);
            }
            else
            {
                Console.WriteLine("Подстрока между вторым и третьим знаком '=': " + mass1[2]);
            }

            Console.ReadKey();
        }
    }
}
