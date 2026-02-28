using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Простой IO с File Type *****\n");
            try
            {
                string[] myTasks = {
                  "Fix bathroom sink", "Call Dave",
                  "Call Mom and Dad", "Play Xbox 360"};

                // Записать все данные в файл на диск
                File.WriteAllLines(@"F:\tasks.txt", myTasks);

                // прочитать все данные и вывести на экран
                foreach (string task in File.ReadAllLines(@"F:\tasks.txt"))
                {
                    Console.WriteLine("{0}", task);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}