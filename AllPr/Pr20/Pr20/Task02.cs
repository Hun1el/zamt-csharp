using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var17
{
    public class Task02
    {
        public static int[] Number(int number)
        {
            if (number < 100 || number > 999)
            {
                throw new Exception("Ошибка");
            }

            int a = number / 100;
            int b = (number / 10) % 10;
            int c = number % 10;

            int[] n = new int[6];
            n[0] = a * 100 + b * 10 + c;
            n[1] = a * 100 + c * 10 + b;
            n[2] = b * 100 + a * 10 + c;
            n[3] = b * 100 + c * 10 + a;
            n[4] = c * 100 + a * 10 + b;
            n[5] = c * 100 + b * 10 + a;

            return n;
        }
    }
}
