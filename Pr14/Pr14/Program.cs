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
            while (true)
            {
                try
                {
                    Yacht[] yachts = Textfile("file.txt");
                    Console.WriteLine("\n1 - Показать все записи\n2 - Показать запись по номеру\n3 - Поиск по владельцу\n0 - Выход");
                    Console.Write("Ваш выбор: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            All(yachts);
                            break;
                        case 2:
                            Console.Write("Введите номер записи: ");
                            int index = Convert.ToInt32(Console.ReadLine()) - 1;
                            Num(yachts, index);
                            break;
                        case 3:
                            Console.Write("Введите первые 3 буквы владельца: ");
                            string threesym = Console.ReadLine();
                            Owner(yachts, threesym);
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }
                }
                catch (FileNotFoundException ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
                catch (FormatException ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                catch (Exception ex3)
                {
                    Console.WriteLine(ex3.Message);
                }
            }
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

        static void All(Yacht[] yachts)
        {
            foreach (Yacht yacht in yachts)
            {
                Console.WriteLine(yacht);
            }
        }

        static void Num(Yacht[] yachts, int index)
        {
            Console.WriteLine(yachts[index]);
        }

        static void Owner(Yacht[] yachts, string three)
        {
            bool found = false;
            {
                foreach (Yacht yacht in yachts)
                {
                    if (yacht.owner.StartsWith(three, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(yacht);
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Ничего не найдено.");
            }
        }
    }
}
