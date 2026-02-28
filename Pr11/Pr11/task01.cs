using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11
{
    class task01
    {
        int N;
        bool chislo;

        public task01()
        {
            this.N = 0;
            this.chislo = false;
        }

        public void Number(int number)
        {
            N = number;
        }

        public void Check()
        {
            int first = N / 100;
            int last = N % 10;
            chislo = (first == last);
        }

        public void Result()
        {
            if (chislo)
            {
                Console.WriteLine(N + " читается одинаково слева направо и справа налево.");
            }
            else
            {
                Console.WriteLine(N + " НЕ читается одинаково слева направо и справа налево.");
            }
        }
    }
}
