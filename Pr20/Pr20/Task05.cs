using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var17
{
    public class Task05
    {
        public static int RootCount(double A, double B, double C)
        {
            if (A == 0)
            {
                throw new ArgumentException("A не может быть = 0.");
            }

            double D = B * B - 4 * A * C;

            if (D > 0)
                return 2;
            else if (D == 0)
                return 1;
            else
                return 0;
        }
    }
}
