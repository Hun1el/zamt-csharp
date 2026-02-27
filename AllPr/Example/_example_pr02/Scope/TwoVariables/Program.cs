using System;

namespace TwoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                float t = 22.5f;  // ℃
                Console.WriteLine($"temperature = {t}");
            }

            {
                float t = 11.35f; // час.мин
                Console.WriteLine($"time = {t}");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
