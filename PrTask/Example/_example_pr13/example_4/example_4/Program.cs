using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Перегрузка методов

namespace example_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Overload ob = new Overload();

            int resI;
            double resD;
            // Вызвать все варианты метода OvlDemo().
            ob.OvlDemo();
            Console.WriteLine();

            ob.OvlDemo(2);
            Console.WriteLine();

            resI = ob.OvlDemo(4, 6);
            Console.WriteLine("Результат вызова метода ob.OvlDemo(4, 6): " + resI);

            resD = ob.OvlDemo(1.1, 2.32);
            Console.WriteLine("Результат вызова метода ob.OvlDemo(1.1, 2.32): " + resD);
        }
    }
}
