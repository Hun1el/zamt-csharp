using System;

namespace ex_class04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);

            Console.WriteLine("Area of r1: " + r1.Area());

            Console.WriteLine("Area of r2: " + r2.Area());
        }
    }
}
