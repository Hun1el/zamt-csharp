using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_linq_easy4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill", "Ada" };

            var selectedPeople = from p in people
                                 where p.Length == 3
                                 select p;

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}
