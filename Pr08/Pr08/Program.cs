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

                    // Задание 2
                    case "2":
                    two:
                        try
                        {
                            Console.WriteLine("Задание 2. В вещественном массиве известны данные о количестве осадков, выпавших за каждый день месяца N. \nНайти общее число осадков, выпавших по нечетным числам этого месяца.");
                            Console.WriteLine("Выберите месяц.(Укажите цифру от 1 до 12)");
                            double total = Two();

                            Console.WriteLine("\nОбщее число осадков по нечетным числам: {0} мм.", Math.Round(total, 2));
                            break;
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
                    case "3":
                    three:
                        try
                        {
                            Console.WriteLine("Задание 3. Вводится строка. Подсчитать количество содержащихся в ней строчных букв латинского алфавита.");
                            Console.WriteLine("Введите строку: ");
                            string str1 = Console.ReadLine();
                            int count = Three(str1);

                            Console.WriteLine("Количество сточных букв латинского алфавита: " + count);
                            break;
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

        static int Three(string str1)
        {
            int count = 0;
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            foreach (char ch in str1)
            {
                for (int i = 0; i < eng.Length; i++)
                {
                    if (ch == eng[i])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static int Four(string str2)
        {
            int countruseng = 0;
            char[] ruseng = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z',
                              'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M','N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z',
                              'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ',
                              'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ' };

            foreach (char ch2 in str2)
            {
                for (int i = 0; i < ruseng.Length; i++)
                {
                    if (ch2 == ruseng[i])
                    {
                        countruseng++;
                    }
                }
            }

            return countruseng;
        }
    }
}
