using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var17
{
    public class Task04
    {
        public static string DecToOct(int A)
        {
            if (A < 100 || A > 999)
            {
                throw new Exception("Ошибка");
            }

            string ten = String.Empty;
            while (A > 0)
            {
                int remain = A % 8;
                ten = remain.ToString() + ten;
                A /= 8;
            }
            return ten;
        }
    }
}
