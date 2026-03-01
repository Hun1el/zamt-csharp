using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task01();
        }
        static void Task01()
        {
            try
            {
                int A = Convert.ToInt32(ReadRegistry("task01", "A"));
                int B = Convert.ToInt32(ReadRegistry("task01", "B"));
                int C = Convert.ToInt32(ReadRegistry("task01", "C"));

                bool result = A > 0 || B > 0 || C > 0;

                WriteRegistry("task01", "result1", result);
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
