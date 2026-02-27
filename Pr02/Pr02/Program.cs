//ВАРИАНТ № А17/Б9
//1. Дана масса M (М - целое положительное число) в килограммах. Используя операцию деления нацело, найти количество полных тонн в ней (1 тонна = 1000 кг).
//2. Проверить истинность высказывания: "Сумма всех цифр данного положительного трехзначного числа является четным числом".
//3.Проверить истинность высказывания: "Цифры данного целого положительного четырехзначного числа образуют убывающую последовательность".
//4.С некоторого момента прошло N дней (N > 0). Сколько полных недель прошло за этот период?
//5. Дано целое число N в диапазоне от -9000 до 9000. Вывести строку-описание данного числа, например: "положительное четырехзначное число" или "отрицательное двузначное".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Задание 1
        one:
            Console.WriteLine("Задание 1. Введите массу в килограммах (целое число):");
            try
            {
                int mass = Convert.ToInt32(Console.ReadLine());
                if (mass < 0)
                {
                    Console.WriteLine("Введите неотрицательное число.");
                    goto one;
                }

                int ton = mass / 1000;
                Console.WriteLine("{0} килограмм = {1} полных тонн", mass, ton);
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
            Console.WriteLine("Задание 2. Введите положительное трехзначное число:");
            try
            {
                int chislo1 = Convert.ToInt32(Console.ReadLine());

                if (chislo1 < 100 || chislo1 > 999)
                {
                    Console.WriteLine("Введите корректное трехзначное число.");
                    goto two;
                }

                int summa = (chislo1 / 100) + (chislo1 / 10 % 10) + (chislo1 % 10);

                if (summa % 2 == 0)
                {
                    Console.WriteLine("Сумма всех цифр числа является четным числом.");
                }
                else
                {
                    Console.WriteLine("Сумма всех цифр числа является нечетным числом.");
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto two;
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto two;
            }

        // Задание 3
        three:
            Console.WriteLine("Задание 3. Введите целое положительное четырехзначное число:");
            try
            {
                int chislo2 = Convert.ToInt32(Console.ReadLine());

                if (chislo2 < 1000 || chislo2 > 9999)
                {
                    Console.WriteLine("Введите корректное четырехзначное число.");
                    goto three;
                }

                int d1 = chislo2 / 1000;
                int d2 = (chislo2 / 100) % 10;
                int d3 = (chislo2 / 10) % 10;
                int d4 = chislo2 % 10;

                if (d1 > d2 && d2 > d3 && d3 > d4)
                {
                    Console.WriteLine("Цифры числа образуют убывающую последовательность.");
                }
                else
                {
                    Console.WriteLine("Цифры числа не образуют убывающую последовательность.");
                }
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

        // Задание 4
        four:
            Console.WriteLine("Задание 4. Введите количество дней (N > 0):");
            try
            {
                int day = Convert.ToInt32(Console.ReadLine());

                if (day <= 0)
                {
                    Console.WriteLine("Введите положительное число дней.");
                    goto four;
                }

                int week = day / 7;
                Console.WriteLine("Количество полных недель: {0}", week);
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

            Console.ReadKey();
        }
    }
}
