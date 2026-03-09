using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_class01
{
    class Program
    {
        static void Main(string[] args)
        {
            //объект 1 - экземпляр класса
            Building house = new Building(); // создание объекта Building

            //объект 2 - экземпляр класса
            Building office = new Building();

            int areaPP; // площадь на одного человека

            // присвоить значения полям в объекте house. 
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // присвоить значения полям в объекте office. 
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            // вычисляем площадь на одного человека в жилом доме 
            areaPP = house.Area / house.Occupants;

            Console.WriteLine("house has:\n  " +
                              house.Floors + " floors\n  " +
                              house.Occupants + " occupants\n  " +
                              house.Area + " total area\n  " +
                              areaPP + " area per person");

            Console.WriteLine();

            // вычисляем площадь на одного человека в жилом доме  
            areaPP = office.Area / office.Occupants;

            Console.WriteLine("office has:\n  " +
                              office.Floors + " floors\n  " +
                              office.Occupants + " occupants\n  " +
                              office.Area + " total area\n  " +
                              areaPP + " area per person");
        }
    }
}