using System;

namespace OperatorGOTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            
                goto Label;

            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");

        Label:
            Console.WriteLine("End");

            // Delay
            Console.ReadKey();
        }
    }
}
