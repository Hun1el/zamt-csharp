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

            //Задание 16
            Console.Write("Введите длину дистанции (метров): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите время (минут.секунд): ");
            double time = Convert.ToDouble(Console.ReadLine());

            int minute = Convert.ToInt32(time / 1);
            double a = time % 1;
            int second = Convert.ToInt32(a * 100);
            int totaltime = minute * 60 + second;

            double speedmeter = distance / totaltime;
            double speedhour = speedmeter * 3.6;

            Console.WriteLine("Вы бежали со скоростью " + speedhour + "км/час");
        }
    }
}
