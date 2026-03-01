// Вариант 17
// Название яхты (char), владелец (char), площадь парусов (float), количества мачт (int), стоимость тыс.долл. (float).
// Поиск по первым трем буквам владельца.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14
{
    struct Yacht
    {
        public string name;
        public string owner;
        public double sail;
        public int masts;
        public double price;

        public override string ToString()
        {
            return $"{name}, {owner}, {sail} м^2, {masts} мачт, {price} тыс. долл.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
