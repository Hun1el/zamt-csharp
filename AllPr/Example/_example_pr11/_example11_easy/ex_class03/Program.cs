using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_class03
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);

            Console.WriteLine("Maximum occupants for house if each has " +
                              300 + " square feet: " +
                              house.MaxOccupant(300));

            Console.WriteLine("Maximum occupants for office if each has " +
                              300 + " square feet: " +
                              office.MaxOccupant(300));
        }
    }
}