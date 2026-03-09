using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11
{
    class task02
    {
        int A;
        int B;
        int prod;
        public task02()
        {
            this.A = 0;
            this.B = 0;
            this.prod = 1;
        }
        public void Number(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public void Calc()
        {
            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 0)
                {
                    prod *= i;
                }
            }

            if (prod == 1)
            {
                prod = 0;
            }
        }
        public void Result()
        {
            if (prod == 0)
            {
                Console.WriteLine("В диапазоне " + (A, B) + " нет четных чисел.");
            }
            else
            {
                Console.WriteLine("Произведение всех четных чисел в диапазоне " + (A, B) + " равно " + prod);
            }
        }
    }
}
