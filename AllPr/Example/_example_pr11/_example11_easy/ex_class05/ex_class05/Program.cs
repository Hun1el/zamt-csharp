using System;

namespace ex_class05
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            Destruct ob = new Destruct(0);

            for (count = 1; count < 100000; count++)
                ob.Generator(count);

            Console.WriteLine("Done");
        }
    }
}
