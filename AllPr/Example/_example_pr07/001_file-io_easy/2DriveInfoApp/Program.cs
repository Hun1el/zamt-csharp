using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Работа с DriveInfo *****\n");

            // получить инф обо всех разделах/дисках
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            // выводим сведения об устройствах
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine("Имя: {0}", d.Name);
                Console.WriteLine("Тип: {0}", d.DriveType);

                // проверяем, смонтировано ли устройство
                if (d.IsReady)
                {
                    Console.WriteLine("Полный объем (в байтах): {0}", d.TotalSize);
                    Console.WriteLine("Полный объем (в Гб): {0}", d.TotalSize/1024/1024/1024);
                    Console.WriteLine("Свободное пространство (в байтах): {0}", d.TotalFreeSpace);
                    Console.WriteLine("Свободное пространство (в Гб): {0}", d.TotalFreeSpace/1024/1024/1024);
                    Console.WriteLine("Формат устройства: {0}", d.DriveFormat);
                    Console.WriteLine("Метка тома: {0}", d.VolumeLabel);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}