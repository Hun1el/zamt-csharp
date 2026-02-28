//ВАРИАНТ № А17/Б10
//1. Дано целое число N (N > 0). Если N - нечетное, то вывести произведение нечетных чисел до этого числа (1*3*5*N); если N - четное, то вывести произведение четных чисел до этого числа (2*4*6*N). Чтобы избежать целочисленного переполнения, вычислять это выражение с помощью вещественной переменной и выводить его как вещественное число. (Пример, 6=2*4*6; 9 = 1 * 3 * 5 * 7 * 9).
//2. Дан целочисленный массив, состоящий из N элементов (N > 0). Найти сумму и произведение всех чисел из данного массива.
//3. Написать функцию int Quarter(X, Y) целого типа, определяющую номер координатной четверти, в которой находится точка с ненулевыми целыми координатами (X, Y).
//4. Написать функцию bool IsSquare(K) логического типа, возвращающую True, если целый параметр K (K > 0) является квадратом некоторого целого числа, и False в противном случае.
//5. Вводится строка, состоящая из слов разделенных точками. Длина строки может быть разной. Сформировать и вывести подстроку, расположенную между первой и второй точками исходной строки. Если в строке менее двух точек, то вывести всю исходную строку.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Задание 1
        one:
            Console.WriteLine("Задание 1. Дано целое число N (N > 0). Если N - нечетное - вывести произведение нечетных чисел до этого числа (1*3*5*N);Если N - четное - вывести произведение четных чисел до этого числа (2*4*6*N).");
            try
            {
                Console.Write("Введите значение N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                task01 task1 = new task01(N);

                if (N <= 0)
                {
                    Console.WriteLine("Число должно быть больше 0\n");
                    goto one;
                }

                int result = task1.Result();
                Console.WriteLine("Результат для N= " + N + ": " + result);
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
        two:
            Console.WriteLine("\nЗадание 2. Дан целочисленный массив, состоящий из N элементов. Найти сумму и произведение всех чисел из данного массива.");
            try
            {
                Console.Write("Введите количество элементов массива N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                task02 task2 = new task02(N);

                int[] array = task2.GetArray();
                Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));

                int sum = task2.Sum();
                int product = task2.Prod();

                Console.WriteLine($"\nСумма элементов массива: " + sum);
                Console.WriteLine($"Произведение элементов массива: " + product);
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

        // Задание 3
        three:
            Console.WriteLine("Задание 3.");
            try
            {
                Console.Write("Введите x: ");
                string x = Console.ReadLine();

                Console.Write("Введите y: ");
                string y = Console.ReadLine();

                task03 task3 = new task03();

                int num = task3.Num(x, y);

                Console.WriteLine("Точка " + (x, y) + "находится в " + num + "-й четверти.");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message + "\n");
                goto three;
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message + "\n");
                goto three;
            }

            Console.ReadKey();
        }
    }
}
