using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_5
{
    class NamedArgsDemo
    {
        // Выяснить, делится ли одно значение нацело на другое.
        public bool IsFactor(int val, int divisor)
        {
            if ((val % divisor) == 0) return true;
            return false;
        }
    }
}
