using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Работа с классом Directory(Info) *****\n");
            ShowWindowsDirectoryInfo();
            DisplayImageFiles();
            ModifyAppDirectory();
            FunWithDirectoryType();
            Console.ReadLine();
        }

        #region Display basic info about C:\Windows
        static void ShowWindowsDirectoryInfo()
        {
            // Dump directory information.
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("Полное имя: {0}", dir.FullName);
            Console.WriteLine("Имя каталога: {0}", dir.Name);
            Console.WriteLine("Родительский каталог: {0}", dir.Parent);
            Console.WriteLine("Время создания: {0}", dir.CreationTime);
            Console.WriteLine("Атрибуты: {0}", dir.Attributes);
            Console.WriteLine("Корневой каталог: {0}", dir.Root);
            Console.WriteLine("**************************\n");
        } 
        #endregion

        #region Display info on JPG files
        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            // получить все файлы с расширением *.jpg
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            // сколько файлов найдено?
            Console.WriteLine("найдено {0} *.jpg файлов\n", imageFiles.Length);

            // выводим информацию о каждом найденом файле
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("Имя файла: {0}", f.Name);
                Console.WriteLine("Размер файла (Кб): {0}", f.Length/1024);
                Console.WriteLine("Время создания: {0}", f.CreationTime);
                Console.WriteLine("Атрибуты: {0}", f.Attributes);
                Console.WriteLine("***************************\n");
            }
        } 
        #endregion

        #region Modify directory structure
        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(".");

            // создать \MyFolder в начальном каталоге
            dir.CreateSubdirectory("MyFolder");

            // получить возвращенный объект DirectoryInfo
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");
            //DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"Моя папка 2\что-то");

            // вывести путь к ..\MyFolder2\Data.
            Console.WriteLine("New Folder is: {0}", myDataFolder);
        } 
        #endregion

        #region Use Directory class
        static void FunWithDirectoryType()
        {
            // вывести список всех логических устройств на ПК
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives:");
            foreach (string s in drives)
                Console.WriteLine("--> {0} ", s);

            // удалить созданные ранее подкаталоги
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"C:\MyFolder");

                //второй параметр указывает, на удаление вложенных подкаталогов
                Directory.Delete(@"C:\MyFolder2", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        } 
        #endregion

    }
}