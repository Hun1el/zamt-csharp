using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//возвр значение из метода

namespace ex_class02
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();
            int areaPP; // area per person 

            // Assign values to fields in house. 
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Assign values to fields in office. 
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            // Obtain area per person for house. 
            areaPP = house.AreaPerPerson();

            Console.WriteLine("house has:\n  " +
                              house.Floors + " floors\n  " +
                              house.Occupants + " occupants\n  " +
                              house.Area + " total area\n  " +
                              areaPP + " area per person");


            Console.WriteLine();

            // Obtain area per person for office. 
            areaPP = office.AreaPerPerson();

            Console.WriteLine("office has:\n  " +
                              office.Floors + " floors\n  " +
                              office.Occupants + " occupants\n  " +
                              office.Area + " total area\n  " +
                              areaPP + " area per person");
        }
    }
}