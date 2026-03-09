// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
//ВАРИАНТ № А17/Б10
//1. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».
//2. Даны два целых положительных числа A и B (A < B). Найти произведение всех чисел расположенных между этими числами A и B.
//3. Вводится строка, состоящая из слов разделенных точками. Длина строки может быть разной. Сформировать и вывести подстроку, расположенную между первой и второй точками исходной строки. Если в строке менее двух точек, то вывести всю исходную строку.
//4. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести количество слов в строке.
//5. Дан целочисленный массив, состоящий из N элементов и целые числа K и L (1 ≤ K ≤ L ≤ N). Найти сумму элементов массива с номерами от K до L включительно.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            try
            {
                Console.WriteLine("Задание 1. Даны три целых числа: A, B, C. Проверить высказывание 'Каждое из чисел A, B, C положительное.'");
                string inputfile1 = "input1.txt";
                string outputfile1 = "output1.txt";

                string[] line1 = File.ReadAllLines(inputfile1);

                int A1 = Convert.ToInt32(line1[0]);
                int B1 = Convert.ToInt32(line1[1]);
                int C1 = Convert.ToInt32(line1[2]);

                bool plus = (A1 > 0 && B1 > 0 && C1 > 0);

                File.WriteAllText(outputfile1, plus.ToString());
                Console.WriteLine("Вывод успешно записан в файл!");
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

            //Задание 2
            try
            {
                Console.WriteLine("\nЗадание 2.");
                string inputfile2 = "input2.txt";
                string outputfile2 = "output2.txt";

                string[] line2 = File.ReadAllLines(inputfile2);
                int A2 = Convert.ToInt32(line2[0]);
                int B2 = Convert.ToInt32(line2[1]);

                if (A2 <= 0 || B2 <= 0)
                {
                    Console.WriteLine("A и B должны быть положительными числами.");
                    File.WriteAllText(outputfile2, "Ошибка: A и B должны быть положительными.");
                }
                else if (A2 >= B2)
                {
                    Console.WriteLine("A должно быть меньше B.");
                    File.WriteAllText(outputfile2, "Ошибка: A должно быть меньше B.");
                }
                else
                {
                    int prod = 1;

                    for (int i = A2 + 1; i < B2; i++)
                    {
                        prod *= i;
                    }

                    File.WriteAllText(outputfile2, prod.ToString());
                    Console.WriteLine("Вывод успешно записан в файл!");
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Ошибка: неверный формат данных. Проверьте input2.txt. " + ex1.Message);
                File.WriteAllText("output2.txt", "Ошибка: неверный формат данных. Проверьте input2.txt.");
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine("Ошибка: " + ex2.Message);
                File.WriteAllText("output2.txt", "Ошибка: Индекс находился вне границ массива. Проверьте input2.txt.");
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine("Ошибка: Директория не найдена. " + ex3.Message);
            }
            catch (FileNotFoundException ex4)
            {
                Console.WriteLine("Ошибка: Файл не найден. " + ex4.Message);
            }

            //Задание 3
            try
            {
                Console.WriteLine("\nЗадание 3. Вводится строка, разделенная точками. Вывести подстроку, расположенную между первой и второй точками.");
                string inputfile3 = "input3.txt";
                string outputfile3 = "output3.txt";
                string str1;

                using (StreamReader reader = new StreamReader(inputfile3))
                {
                    str1 = reader.ReadLine();
                }

                str1 = str1.Replace(" ", ".");
                Console.WriteLine("Строка с заменёнными пробелами на точки: " + str1);
                int first = str1.IndexOf('.');
                int second = str1.IndexOf('.', first + 1);

                using (StreamWriter writer = new StreamWriter(outputfile3))
                {
                    writer.WriteLine("Строка с заменёнными пробелами на точки: " + str1);

                    if (first != -1 && second != -1)
                    {
                        string result = str1.Substring(first + 1, second - first - 1);
                        Console.WriteLine("Подстрока между первой и второй точками: " + result);
                        writer.WriteLine("Подстрока между первой и второй точками: " + result);
                    }
                    else
                    {
                        Console.WriteLine("В строке менее двух точек. Исходная строка: " + str1);
                        writer.WriteLine("В строке менее двух точек. Исходная строка: " + str1);
                    }
                }

                Console.WriteLine("Вывод успешно записан в файл!");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Ошибка: неверный формат данных. Проверьте input2.txt. " + ex1.Message);
                File.WriteAllText("output3.txt", "Ошибка: неверный формат данных. Проверьте input3.txt.");
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine("Ошибка: " + ex2.Message);
                File.WriteAllText("output3.txt", "Ошибка: Индекс находился вне границ массива. Проверьте input3.txt.");
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine("Ошибка: Директория не найдена. " + ex3.Message);
            }
            catch (FileNotFoundException ex4)
            {
                Console.WriteLine("Ошибка: Файл не найден. " + ex4.Message);
            }

            //Задание 4
            try
            {
                Console.WriteLine("\nЗадание 4. Вводится строка из слов, разделённых подчеркиваниями. Определить и вывести количество слов в строке.");
                string inputfile4 = "input4.txt";
                string outputfile4 = "output4.txt";
                string str2;

                using (StreamReader reader = new StreamReader(inputfile4))
                {
                    str2 = reader.ReadLine();
                }

                str2 = str2.Replace(" ", "_");
                Console.WriteLine("Строка с заменёнными пробелами на подчёркивания: " + str2);
                string[] word = str2.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                int count = word.Length;

                using (StreamWriter writer = new StreamWriter(outputfile4))
                {
                    writer.WriteLine("Строка с заменёнными пробелами на точки: " + str2);
                    writer.WriteLine("Количество слов в строке: " + count);
                }

                Console.WriteLine("Количество слов в строке: " + count);
                Console.WriteLine("Вывод успешно записан в файл!");
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Ошибка: неверный формат данных. Проверьте input2.txt. " + ex1.Message);
                File.WriteAllText("output4.txt", "Ошибка: неверный формат данных. Проверьте input4.txt.");
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine("Ошибка: " + ex2.Message);
                File.WriteAllText("output4.txt", "Ошибка: Индекс находился вне границ массива. Проверьте input4.txt.");
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine("Ошибка: Директория не найдена. " + ex3.Message);
            }
            catch (FileNotFoundException ex4)
            {
                Console.WriteLine("Ошибка: Файл не найден. " + ex4.Message);
            }

            Console.ReadKey();
        }
    }
}
