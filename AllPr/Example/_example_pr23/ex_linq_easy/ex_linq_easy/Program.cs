using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_linq_easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 части запроса LINQ:

            // 1. получение источника данных
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 2. создание запроса
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. выполнение запроса
            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
            }

            Console.ReadKey();
        }
    }
}
