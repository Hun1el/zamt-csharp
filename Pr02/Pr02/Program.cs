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
        }
    }
}
