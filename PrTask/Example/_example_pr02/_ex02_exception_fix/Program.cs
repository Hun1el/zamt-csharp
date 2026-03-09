using System;

namespace ex02_exception_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Введите А");

            //обработчик исключения
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine("METHOD - " + exception.TargetSite.ToString()); //метод
                Console.WriteLine("MESSAGE - " + exception.Message.ToString()); //сообщение об ошибке
                Console.WriteLine("SOURCE - " + exception.Source.ToString()); //источник ошибки
                Console.WriteLine("DATA - " + exception.Data.ToString());   //дополнит информация
                Console.WriteLine("STACK - " + exception.StackTrace.ToString());
            }
        }
    }
}
