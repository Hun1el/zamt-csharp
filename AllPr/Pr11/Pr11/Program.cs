//ВАРИАНТ № А17/Б10
//1. Дано целое положительное трехзначное число N (N>0). Проверить истинность высказывания: «Данное число N читается одинаково слева направо и справа налево».
//2. Даны два целых положительных числа A и B (число A меньше числа B). Найти произведение всех четных чисел расположенных между этими числами A и B.
//3. В вещественном массиве известны данные о количестве осадков, выпавших за каждый день месяца N (N - любой месяц в году). Найти общее число осадков, выпавших по четным числам месяца. Предоставить возможность пользователю реализовать заполнение элементов массива случайными (рандомными) числами.
//4. Написать функцию double DegToRad(D) вещественного типа, находящую величину угла в радианах, если дана его величина D в градусах (D — вещественное число, 0 ≤ D ≤ 360). Воспользоваться следующим соотношением: 180° = pi радианов.В качестве значения PI использовать предопределенную константу из библиотеки языка программирования.
//5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести количество слов в строке.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            task01 task1 = new task01();
        one:
            try
            {
                Console.WriteLine("Задание 1. Дано целое положительное трехзначное число N. Проверить истинность высказывания: \n«Данное число N читается одинаково слева направо и справа налево».");
                Console.Write("Введите трехзначное положительное число N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                if (N < 100 || N > 999)
                {
                    Console.WriteLine("Число должно быть положительным трехзначным\n");
                    goto one;
                }

                task1.Number(N);
                task1.Check();
                task1.Result();
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message + "\n");
                goto one;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message + "\n");
                goto one;
            }

            // Задание 2
            task02 task2 = new task02();
        two:
            try
            {
                Console.WriteLine("\nЗадание 2. Даны два целых положительных числа A и B (A < B). \nНайти произведение всех четных чисел расположенных между этими числами A и B.");
                Console.Write("Введите число A (A < B): ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число B (B > A): ");
                int B = Convert.ToInt32(Console.ReadLine());

                if (A >= B)
                {
                    Console.WriteLine("Число A должно быть меньше числа B.");
                    goto two;
                }

                task2.Number(A, B);
                task2.Calc();
                task2.Result();
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message + "\n");
                goto two;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message + "\n");
                goto two;
            }

            // Задание 4
            task04 task4 = new task04();
        four:
            try
            {
                Console.WriteLine("\nЗадание 4.");
                Console.Write("Введите угол в градусах (от 0 до 360): ");
                double gradus = Convert.ToDouble(Console.ReadLine());

                if (gradus < 0 || gradus > 360)
                {
                    Console.WriteLine("Значение градусов должно быть в диапазоне от 0 до 360.");
                    goto four;
                }
                else
                {
                    double radians = task4.DegToRad(gradus);
                    Console.WriteLine("Угол " + gradus + " градусов равен " + radians + " радиан.");
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message + "\n");
                goto four;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message + "\n");
                goto two;
            }

            // Задание 5
            task05 task5 = new task05();
        five:
            try
            {
                Console.WriteLine("\nЗадание 5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести количество слов в строке.");
                Console.Write("Введите строку, состоящую из слов, разделенных подчеркиваниями: ");
                string input = Console.ReadLine();
                string strm = task5.Replaces(input);
                int word = task5.Count(input);

                Console.WriteLine("Строка с подчеркиваниями: " + strm);
                Console.WriteLine("Количество слов в строке: " + word);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message + "\n");
                goto five;
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine(ex2.Message + "\n");
                goto five;
            }

            Console.ReadKey();
        }
    }
}
