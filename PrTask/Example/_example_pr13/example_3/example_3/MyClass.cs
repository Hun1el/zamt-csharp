using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_3
{
    class Min
    {
        public int MinVal(params int[] nums)
        {
            int m;
            if (nums.Length == 0)
            {
                Console.WriteLine("Ошибка: нет аргументов.");
                return 0;
            }

            m = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < m) m = nums[i];
            }

            return m;
        }
    }
}