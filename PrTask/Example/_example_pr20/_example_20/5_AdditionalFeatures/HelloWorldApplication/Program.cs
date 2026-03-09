using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    // Generic Test - используется для тестирования приложений или third-party инструментов:
    // * Которые могут запускаться из командной строки
    // * Которые возвращают значение, определяющее выполнилось приложение или нет.
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine(args[0]);

            if (args[0] == "Hello world")
            {
                return 0; // успешное выполнение приложения
            }
            return 1; // ошибка
        }
    }
}
