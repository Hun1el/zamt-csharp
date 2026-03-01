// ВАРИАНТ № А17/Б10
// 1. Дано четырехзначное целое ненулевое положительное число N (N>0). Проверить истинность высказывания: "Все цифры данного числа различны".
// 2.Ввести пять различных ненулевых целых чисел. Найти произведение трех наибольших чисел.
// 3. Дан целочисленный массив, состоящий из N элементов (N > 0). Если в наборе имеются отрицательные нечетные числа, то найти сумму всех положительных четных чисел, иначе вычислить сумму всех чисел, которые кратные числу 5.
// 4. Написать функцию double TriangleS(a) вещественного типа, вычисляющую по стороне a равностороннего треугольника его площадь S = a2·(3)0.5/4 (параметр a является вещественным). С помощью этой процедуры найти площади трех равносторонних треугольников с данными сторонами.
// 5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести количество слов, у которых второй и последний символ одинаковые.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Pr19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            XPathDocument input1 = new XPathDocument("input1.xml");
            XPathNavigator navigator1 = input1.CreateNavigator();

            string str = navigator1.SelectSingleNode("/task/number").Value;
            int number = Convert.ToInt32(str);

            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Число должно быть четырехзначным.");
            }
            else
            {
                Console.WriteLine("Задание 1 выполнено.");
            }

            bool outputfile1 = number.ToString().Distinct().Count() == 4;

            var output1 = new XElement("result", new XElement("output", outputfile1));
            output1.Save("output1.xml");

            // Задание 2
            XPathDocument input2 = new XPathDocument("input2.xml");
            XPathNavigator navigator2 = input2.CreateNavigator();

            var n = navigator2.Select("/task/numbers/number");

            int[] numbers = new int[5];
            int index = 0;

            while (n.MoveNext())
            {
                int value = Convert.ToInt32(n.Current.Value);

                if (value == 0)
                {
                    Console.WriteLine("Все числа должны быть ненулевыми.");
                }

                numbers[index++] = value;
            }
            if (index != 5)
            {
                Console.WriteLine("Дожно быть ровно 5 числе");
            }
            else
            {
                Console.WriteLine("Задание 2 выполнено.");
            }

            Array.Sort(numbers);
            int prod = numbers[4] * numbers[3] * numbers[2];

            var output2 = new XElement("result", new XElement("prod", prod));
            output2.Save("output2.xml");

            Console.ReadKey();
        }
    }
}
