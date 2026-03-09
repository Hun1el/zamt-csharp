using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13
{
    class task05
    {
        public string Str(string input)
        {
            int first = input.IndexOf('.');
            int second = input.IndexOf('.', first + 1);

            if (first == -1 || second == -1)
            {
                return input;
            }

            return input.Substring(first + 1, second - first - 1);
        }
    }
}
