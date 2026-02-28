using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_class02
{
    class Building
    {
        public int Floors;    // number of floors 
        public int Area;      // total square footage of building 
        public int Occupants; // number of occupants 

        // Return the area per person.  
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }
}
