using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_class05
{
    class Destruct
    {
        public int x;

        public Destruct(int i)
        {
            x = i;
        }

        // Called when object is recycled. 
        ~Destruct()
        {
            Console.WriteLine("Destructing " + x);
        }

        // Generates an object that is immediately destroyed. 
        public void Generator(int i)
        {
            Destruct o = new Destruct(i);
        }

    }
}
