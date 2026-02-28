using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11
{
    class task05
    {
        public string Replaces(string str)
        {
            return str.Replace(' ', '_');
        }

        public int Count(string str)
        {
            string[] words = str.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
