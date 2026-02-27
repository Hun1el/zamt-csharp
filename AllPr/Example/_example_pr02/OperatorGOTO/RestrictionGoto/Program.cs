using System;

namespace RestrictionGoto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool statusOk = true, dataAvailable = true;
            int importantVariable = 0, x = 1;

            if (statusOk)
            {
                if (dataAvailable)
                {
                    importantVariable = x;
                    goto MID_LOOP; // ОШИБКА: Нет такой метки «MID_LOOP» в области видимости оператора goto
                }
            }
            else
            {
                importantVariable = 33; //GetValue();
            //MID_LOOP: Console.WriteLine("Много кода.");
            }
        MID_LOOP: Console.WriteLine("Много кода.");
        }
    }
}
