using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solonikov
{
    public class Class5
    {
        public int Task05(string str)
        {
            var words = str.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
