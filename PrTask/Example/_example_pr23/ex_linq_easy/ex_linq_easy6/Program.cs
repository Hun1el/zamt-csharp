using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_linq_easy6
{
    class Program
    {
        static void Main(string[] args)
        {
            string startFolder = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE";
  
            IEnumerable<string> fileList = Directory.GetFiles(startFolder, "*.*", SearchOption.AllDirectories);

            var fileQuery = from file in fileList
                            select GetFileLength(file);

            // Cache the results to avoid multiple trips to the file system.  
            long[] fileLengths = fileQuery.ToArray();

            // Return the size of the largest file  
            long largestFile = fileLengths.Max();

            // Return the total number of bytes in all the files under the specified folder.  
            long totalBytes = fileLengths.Sum();

            Console.WriteLine("There are {0} bytes in {1} files under {2}",
                totalBytes, fileList.Count(), startFolder);
            Console.WriteLine("The largest files is {0} bytes or {1} Mb.", largestFile, largestFile/1024/1024);

            Console.ReadKey();
        }

        static long GetFileLength(string filename)
        {
            long retval = 0;
            try
            {
                FileInfo fi = new FileInfo(filename);
                retval = fi.Length;
            }
            catch (FileNotFoundException)
            {
                retval = 0;
            }
            return retval;
        }
    }
}
