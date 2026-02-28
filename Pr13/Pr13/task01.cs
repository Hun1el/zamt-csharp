using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13
{
    class task01
    {
        private int N;
        public task01(int N)
        {
            this.N = N;
        }

        private int Result(int N)
        {
            int product = 1;

            if (N % 2 == 0)
            {
                for (int i = 2; i <= N; i += 2)
                {
                    product *= i;
                }
            }
            else
            {
                for (int i = 1; i <= N; i += 2)
                {
                    product *= i;
                }
            }

            return product;
        }
        public int Result(bool truefalse = true)
        {
            return Result((int)N);
        }
    }
}
