using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_4
{
    class Overload
    {
        public void OvlDemo()
        {
            Console.WriteLine("Без параметров");
        }

        // Перегрузка метода OvlDemo с одним целочисленным параметром.
        public void OvlDemo(int a)
        {
            Console.WriteLine("Один параметр: " + a);
        }

        // Перегрузка метода OvlDemo с двумя целочисленными параметрами.
        public int OvlDemo(int a, int b)
        {
            Console.WriteLine("Два параметра: " + a + " " + b);
            return a + b;
        }

        // Перегрузка метода OvlDemo с двумя параметрами типа double.
        public double OvlDemo(double a, double b)
        {
            Console.WriteLine("Два параметра типа double: " + a + " " + b);
            return a + b;
        }
    }
}
