using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChkNum ob = new ChkNum();

            for (int i = 2; i < 10; i++)
            {
                if (ob.IsPrime(i)) Console.WriteLine(i + " простое число.");
                else Console.WriteLine(i + " непростое число.");
            }
        }
    }
}
