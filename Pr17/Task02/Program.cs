using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task02();
        }
        static void Task02()
        {
            try
            {
                int N = Convert.ToInt32(ReadRegistry("task02", "N"));
                if (N <= 0)
                {
                    WriteRegistry("task02", "result2", "Error: N > 0");
                    return;
                }
                int days = N * 7;
                WriteRegistry("task02", "result2", days);
            }
            catch (FormatException exception1)
            {
                Console.WriteLine(exception1.Message);
            }
            catch (ArgumentException exception2)
            {
                Console.WriteLine(exception2.Message);
            }
            catch (Exception exception3)
            {
                Console.WriteLine(exception3.Message);
            }
        }
        static void WriteRegistry(string task, string key, object value)
        {
            string path = "PR_17\\" + task;
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(path))
            {
                registryKey.SetValue(key, value);
            }
        }
        static string ReadRegistry(string task, string key)
        {
            string path = "PR_17\\" + task;
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(path))
            {
                object value = registryKey.GetValue(key);
                return value.ToString();
            }
        }
    }
}
