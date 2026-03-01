using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solonikov
{
    public class Class1
    {
        public bool Task01(int A, int B)
        {
            return (A % 2 != 0 && B % 2 == 0) || (A % 2 == 0 && B % 2 != 0);
        }
    }
}