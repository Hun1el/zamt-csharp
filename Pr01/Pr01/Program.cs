using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01
{
    internal class Program
    {
        // Вариант 17
        static void Main(string[] args)
        {
            //Задание 17
            Console.Write("Введите радиус основания (см): ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту цилиндра (см): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double form1 = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine("Объем цилиндра: " + form1 + " см.куб");
        }
    }
}
