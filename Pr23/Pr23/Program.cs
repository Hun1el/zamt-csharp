using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            one:
            try
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Введите четырехзначное число (N > 0):");
                int N1 = Convert.ToInt32(Console.ReadLine());
                if (N1 < 1000 || N1 > 9999)
                {
                    Console.WriteLine("Число должно быть четырехзначным и положительным");
                    goto one;
                }

                bool truefalse = N1.ToString().Distinct().Count() == 1;
                Console.WriteLine($"Все цифры числа {N1} одинаковые: {truefalse}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                goto one;
            }

            two:
            try
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Введите четырехзначное число (N > 0):");
                int N2 = int.Parse(Console.ReadLine());
                if (N2 < 1000 || N2 > 9999)
                {
                    Console.WriteLine("число должно быть четырехзначным и положительным.");
                    goto two;
                }

                int result = N2.ToString()
                               .Select(d => Convert.ToInt32(d.ToString())).Take(2).Aggregate((a, b) => a * b) - N2.ToString()
                               .Select(d => Convert.ToInt32(d.ToString()))
                               .Skip(2).Aggregate((a, b) => a * b);

                Console.WriteLine($"Разница между произведениями первых двух и последних двух цифр числа {N2}: {result}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto two;
            }

            try
            {
                Console.WriteLine("Задание 3");
                Random random = new Random();
                int[] array = new int[25];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 100);
                }
                Console.WriteLine("Созданный массив: " + string.Join(", ", array));

                int[] revers = array.Reverse().ToArray();
                Console.WriteLine("Перевернутый массив: " + string.Join(", ", revers));

                int sum = array.Sum();
                Console.WriteLine("Сумма массива: " + sum);

                long prod = array.Aggregate((acc, x) => acc * x);
                Console.WriteLine("Произведение массива: " + prod);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                Console.WriteLine("Задание 4");
                Random random = new Random();
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 100);
                }

                Console.WriteLine("Исходный массив: " + string.Join(", ", array));

                int felem = array[0];
                var trans = array
                   .Select((value, index) =>
                   {
                        if (index > 0 && index < array.Length - 1 && value % 2 == 0)
                        {
                            return value + felem;
                        }
                        else
                        {  
                            return value;
                        }
                   }).ToArray();
                Console.WriteLine("Преобразованный массив: " + string.Join(", ", trans));
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadKey();
        }
    }
}
