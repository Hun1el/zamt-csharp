using System;

namespace ScopeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //int variable = 5;
                //Console.WriteLine(variable);
            }

            int variable = 5;
            Console.WriteLine(variable);

            // Delay
            Console.ReadKey();
        }
    }
}
