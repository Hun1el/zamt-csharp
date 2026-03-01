using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solonikov
{
    public class Class4
    {
        public int Calc(int A1, int B1, int Op)
        {
            int result = 0;
            switch (Op)
            {
                case 1:
                    result = A1 - B1;
                    break;
                case 2:
                    result = A1 * B1;
                    break;
                case 3:
                    result = A1 / B1;
                    break;
                case 4:
                    result = A1 + B1;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
