using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дано количество часов, минут и секунд с начала суток. 
//Вычислить общее количество секунд

namespace var38
{
    //1 задание
    class task01
    {
        int min = 0;
        int sec = 0;
        int hour = 0;
        int all = 0;

        //метод
        public void GetSec(int a)
        {
            sec = a;
        }

        public void GetMin(int b)
        {
            min = b;
        }

        public void GetHour(int h)
        {
            hour = h;
        }

        public void GetAllSec()
        {
            all = hour * 3600 + min * 60 + sec;
        }

        public void printSec()
        {
            System.Console.WriteLine(all);
        }
    }
}
