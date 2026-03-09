using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_class03
{
    class Building
    {
        public int Floors;    // number of floors 
        public int Area;      // total square footage of building 
        public int Occupants; // number of occupants 

        // параметризованный конструктор
        public Building(int f, int a, int o)
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        // Display the area per person.  
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }

        // Return the maximum number of occupants if each 
        // is to have at least the specified minimum area. 
        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }
    }
}
