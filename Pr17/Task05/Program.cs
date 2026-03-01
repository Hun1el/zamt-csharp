using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task05();
        }
        static void Task05()
        {
            try
            {
                string str = ReadRegistry("task05", "str");
                int lower = Count(str);
                WriteRegistry("task05", "result5", lower);
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
        static int Count(string str1)
        {
            int count = 0;
            char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 
                           's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char ch in str1)
            {
                for (int i = 0; i < eng.Length; i++)
                {
                    if (ch == eng[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
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
