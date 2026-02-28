// ВАРИАНТ № А17/Б10
// 1. Проверить истинность высказывания: "Сумма всех цифр данного положительного трехзначного числа является четным числом".
// 2. В вещественном массиве хранятся сведения о количестве осадков, выпавших за каждый день месяца N (в месяце должно быть 30 дней). Определить, сколько осадков выпадало в среднем за один день в первую, вторую и третью декады этого месяца (декада состоит из 10 дней). Предоставить возможность пользователю реализовать заполнение элементов массива случайными (рандомными) числами.
// 3. Написать функцию int Max3(A, B, C) целого типа, возвращающую одно максимальное значение из 3-х своих аргументов (параметры A, B, C - целые числа).
// 4. Вводится строка. Длина строки может быть разной. Подсчитать количество содержащихся в этой строке чисел (от 0 до 9). Вычислить и вывести сумму этих чисел.
// 5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Подсчитать количество содержащихся в строке гласных букв.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            try
            {
                Console.WriteLine("Задание 1. Проверить истинность высказывания: Сумма всех цифр данного положительного трехзначного числа является четным числом.");
                string inputfile1 = "input1.txt";
                string outputfile1 = "output1.txt";
                int str1;

                using (StreamReader reader = new StreamReader(inputfile1))
                {
                    str1 = Convert.ToInt32(reader.ReadLine());
                }

                if (str1 < 100 || str1 > 999)
                {
                    Console.WriteLine("Ошибка: число должно быть положительным трёхзначным. Проверьте input1.txt");
                    File.WriteAllText(outputfile1, "Число должно быть положительным трёхзначным.");
                }
                else
                {
                    int summa = (str1 / 100) + (str1 / 10 % 10) + (str1 % 10);

                    using (StreamWriter writer = new StreamWriter(outputfile1))
                    {
                        if (summa % 2 == 0)
                        {
                            Console.WriteLine("Сумма всех цифр числа является четным числом.");
                            writer.WriteLine("Сумма всех цифр числа является четным числом: " + summa);
                            Console.WriteLine("Вывод успешно записан в файл!");
                        }
                        else
                        {
                            Console.WriteLine("Сумма всех цифр числа является нечетным числом.");
                            writer.WriteLine("Сумма всех цифр числа является нечетным числом: " + summa);
                            Console.WriteLine("Вывод успешно записан в файл!");
                        }
                    }

                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Ошибка: неверный формат данных. Проверьте input1.txt. " + ex1.Message);
                File.WriteAllText("output1.txt", "Ошибка: неверный формат данных. Проверьте input1.txt.");
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine("Ошибка: " + ex2.Message);
                File.WriteAllText("output1.txt", "Ошибка: Индекс находился вне границ массива. Проверьте input1.txt.");
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine("Ошибка: Директория не найдена. " + ex3.Message);
            }
            catch (FileNotFoundException ex4)
            {
                Console.WriteLine("Ошибка: Файл не найден. " + ex4.Message);
            }


        }

        static int Max3(int A, int B, int C)
        {
            return Math.Max(A, Math.Max(B, C));
        }
    }
}
