using System;

namespace OperatorGOTO
{
    class Program
    {
        static void Main(string[] args)
        {
        Label:
            Console.WriteLine("Begin");

            if (true)
            {
                goto Label;
            }

            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");

            Console.WriteLine("End");

            // Delay
            Console.ReadKey();
        }
    }
}
