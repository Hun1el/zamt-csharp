using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13
{
    class task02
    {
        private int[] array;

        public task02(int size)
        {
            array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 51);
            }
        }
        public int Sum()
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return sum;
        }

        public int[] GetArray()
        {
            return array;
        }

        public int Prod()
        {
            int prod = 1;
            foreach (int num in array)
            {
                prod *= num;
            }

            return prod;
        }
    }
}
