using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//вывести количество символов в строке

namespace var38
{
    class task02
    {
        string inputStr = "";
        int strLenght = 0;

        public void GetString(string a)
        {
            inputStr = a;
        }

        public void GetStrLenght()
        {
            strLenght = inputStr.Length;
            //return strLenght;
        }

        public void PrintStrLenght()
        {
            Console.WriteLine(strLenght);
        }
    }
}
