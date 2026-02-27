using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoMSDN
{
    public class GotoTest1
    {
        static void Main()
        {
            int x = 200, y = 4, count = 0;
            string[,] array = new string[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    array[i, j] = (++count).ToString();

            Console.Write("Введите число для поиска: ");
            string myNumber = Console.ReadLine();
            bool flag_Found = false;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (array[i, j].Equals(myNumber))
                    {
                        flag_Found = true; //goto Found;
                        break;
                    }
                }

                if (flag_Found) break;
            }

            if (flag_Found)
                Console.WriteLine($"Число {myNumber} найдено.");
            else
                Console.WriteLine($"Число {myNumber} не найдено.");

            Console.WriteLine("Поиск закончен.");
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
