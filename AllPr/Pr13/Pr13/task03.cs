using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13
{
    class task03
    {
        public int Num(int x, int y)
        {
            return Number(x, y);
        }

        public int Num(double x, double y)
        {
            return Number((int)x, (int)y);
        }

        public int Num(string x, string y)
        {
            int intX = Convert.ToInt32(x);
            int intY = Convert.ToInt32(y);

            return Number(intX, intY);
        }

        private int Number(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
