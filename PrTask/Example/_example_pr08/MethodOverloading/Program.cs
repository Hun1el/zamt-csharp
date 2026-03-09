using System;

//Даны два целых числа A и B(A<B). Вывести все целые числа, 
//расположенные между данными числами (включая сами эти числа), 
//в порядке их убывания, а также сумму N этих чисел.

//Написать функцию double Fact(int N) вещественного типа, вычисляющую 
//значение факториала N! = 1·2·…·N(N > 0 - параметр целого типа; 
//вещественное возвращаемое значение используется для того, чтобы 
//избежать целочисленного переполнения при больших значениях N).

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Работа с перегруженными методами *****\n");
            
            // Calls int version of Add()
            //Console.WriteLine(Add(10, 10));
            
            // Calls long version of Add()
            //Console.WriteLine(Add(900000000000, 900000000000));
            
            // Calls double version of Add()
            //Console.WriteLine(Add(4.3, 4.4));

            Console.WriteLine("\nСумма = {0}", Sum(10, 20));
            Console.WriteLine("\nФакториал = {0}", Fact(0));

            Console.ReadLine();
        }

        #region Overloaded Add() methods
        // перегруженные методы
        static int Add(int x, int y)
        { 
		    return x + y; 
		}

        static double Add(double x, double y)
        { 
		    return x + y; 
		}

        static long Add(long x, long y)
        { 
		    return x + y; 
		}

        static int Sum(int A, int B)
        {
            int Result = 0;
            for(int a = A; a<=B; a++)
            {
                Console.Write("{0} ", a);
                Result += a;
            }

            return Result;
        }

        static double Fact(int N)
        {
            double Result = 1.0;

            for(int k=1;k <=N;k++)
            {
                Result *= k;
            }

            return Result;
        }

        #endregion
    }
}