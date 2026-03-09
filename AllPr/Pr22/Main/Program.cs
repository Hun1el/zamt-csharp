using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solonikov;

namespace Main
{
    class Program
    {
        static void Main()
        {
            Class1 task1 = new Class1();
            Class2 task2 = new Class2();
            Class4 task4 = new Class4();
            Class5 task5 = new Class5();

            try
            {
                one:
                Console.WriteLine("Задание 1.");
                Console.Write("Введите число A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A <= 0 || B <= 0)
                {
                    Console.WriteLine("Числа A и B должны быть положительными.");
                    goto one;
                }
                else
                {
                    Console.WriteLine($"Ровно одно из чисел A и B нечетное: {task1.Task01(A, B)}");
                }

                two:
                Console.WriteLine("Задание 2.");
                Console.Write("Введите пятизначное число N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                if (N <= 9999 || N > 99999)
                {
                    Console.WriteLine("N должно быть положительным пятизначным числом.");
                    goto two;
                }
                else
                {
                    Console.WriteLine($"Сумма всех цифр числа N: {task2.Task02(N)}");
                }

                four:
                Console.WriteLine("Задание 4.");
                Console.Write("Введите число A: ");
                int A1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число B: ");
                int B1 = Convert.ToInt32(Console.ReadLine());

                if (A1 == 0 || B1 == 0)
                {
                    Console.WriteLine("Числа A и B должны быть ненулевыми");
                    goto four;
                }
                else
                {
                    Console.Write("Введите код операции (1 - вычитание, 2 - умножение, 3 - деление, 4 - сложение): ");
                }

                int Op = Convert.ToInt32(Console.ReadLine());
                if (Op < 1 || Op > 4)
                {
                    Console.WriteLine("Такого номера нету");
                    goto four;
                }
                else
                {
                    Console.WriteLine($"Результат: {task4.Calc(A1, B1, Op)}");
                }

                Console.WriteLine("Задание 5.");
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                Console.WriteLine($"Количество слов в строке: {task5.Task05(str)}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}");
            }
            Console.ReadKey();
        }
    }
}
