using System;

//int globalVariable = 1; // В C# глобальные переменные недопустимы.

namespace LocalVariable
{
    //int globalVariable = 2; // В C# глобальные переменные недопустимы.

    class Program
    {
        static int field = 3; // Поля класса. Ошибочно называют глобальными перменными.

        static void Main(string[] args)
        {
            int localVariable = 4;

            {
                int localLocalVariable = 5;
            }
        }
    }
}
