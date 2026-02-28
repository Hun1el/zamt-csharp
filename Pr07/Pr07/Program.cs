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
        }
    }
}
