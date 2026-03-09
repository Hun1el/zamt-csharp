using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6
{
    static class NumericFn
    {
        // Возвратить обратное числовое значение.
        static public double Reciprocal(double num)
        {
            return 1 / num;
        }

        // Возвратить дробную часть числового значения.
        static public double FracPart(double num)
        {
            return num - (int)num;
        }

        // Возвратить логическое значение true, если числовое
        // значение переменной num окажется четным.
        static public bool IsEven(double num)
        {
            return (num % 2) == 0 ? true : false;
        }

        // Возвратить логическое значение true, если числовое
        // значение переменной num окажется нечетным.
        static public bool IsOdd(double num)
        {
            return !IsEven(num);
        }
    }
}
