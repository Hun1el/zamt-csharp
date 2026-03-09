using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex_linq_easy5
{
    class Program
    {
        static void Main(string[] args)
        {
            string startFolder = @"C:\Program Files\Microsoft Visual Studio\2022\Community";
            DirectoryInfo dir = new DirectoryInfo(startFolder);

            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            IEnumerable<FileInfo> fileQuery =
            from file in fileList
            where file.Extension == ".txt"
            orderby file.Name
            select file;

            foreach (FileInfo fi in fileQuery)
            {
                Console.WriteLine(fi.FullName);
            }

            Console.ReadKey();
        }
    }
}
