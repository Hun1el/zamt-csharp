using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//подключаем свое пространство имен
using var38;

namespace ex_class_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем экземпляр класса
            task01 task1 = new task01();
            task02 task2 = new task02();
			
			// значения забираем с консоли, не забываем про "отлов" ошибок
            task1.GetMin(10);
            task1.GetSec(11);
            task1.GetHour(10);
            task1.GetAllSec();
            task1.printSec();
            //------------------------------
            task2.GetString("1234567890");
            task2.GetStrLenght();
            task2.PrintStrLenght();
        }
    }
}
