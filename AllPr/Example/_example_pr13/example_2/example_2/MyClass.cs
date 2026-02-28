using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    internal class MyClass
    {
        private int alpha;  // закрытый доступ, указываемый явно
        int beta;           // закрытый доступ по умолчанию

        public int gamma;   // открытый доступ
                            // Методы, которым доступны члены alpha и beta данного класса.


        public void SetAlpha(int а)
        {
            alpha = а;
        }

        public int GetAlpha()
        {
            return alpha;
        }
        public void SetBeta(int a)
        {
            beta = a;
        }
        public int GetBeta()
        {
            return beta;
        }
    }
}
