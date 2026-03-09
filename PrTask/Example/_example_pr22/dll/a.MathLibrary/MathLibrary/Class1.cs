using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//наше пространство имен - название выбираем сами
namespace MathLibraryKV
{
    //один или несколько классов
    public class Class1
    {
        //один или несколько методов
        //это метод для вычитания...
        public float Sub(float a, float b)
        {
            return a - b;
        }

        public float Mul(float a, float b)
        {
            return a * b;
        }

        public float Dev(float a, float b)
        {
            return a / b;
        }

        public float Pow(float a)
        {
            return a * a;
        }
    }
}
