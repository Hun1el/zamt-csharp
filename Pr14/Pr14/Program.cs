// Вариант 17
// Название яхты (char), владелец (char), площадь парусов (float), количества мачт (int), стоимость тыс.долл. (float).
// Поиск по первым трем буквам владельца.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        static Yacht[] Textfile(string namefile)
        {
            string[] lines = File.ReadAllLines(namefile);
            Yacht[] yachts = new Yacht[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');

                yachts[i] = new Yacht
                {
                    name = parts[0],
                    owner = parts[1],
                    sail = Convert.ToDouble(parts[2]),
                    masts = Convert.ToInt32(parts[3]),
                    price = Convert.ToDouble(parts[4]),
                };
            }
            return yachts;
        }
    }
}
