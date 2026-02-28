using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = pow(5.0, 2.0);

            int Sum = Addition(1, 2, 3, 4, 5);
            int[] array = new int[] { 10, 20, 30, 40 };
            int sum2 = Addition(array);

            AdditionArray(array, 4);
        }

        static double pow(double A, double B)
        {
            return Math.Pow(A,B);
        }

        // передача параметра с params
        static int Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }

            return result;
        }

        // передача массива
        static void AdditionArray(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }

            Console.WriteLine(result);
        }
    }
}