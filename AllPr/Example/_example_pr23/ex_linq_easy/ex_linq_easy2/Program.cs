using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_linq_easy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            // создаем новый список для результатов
            var selectedPeople = new List<string>();

            // проходим по массиву
            foreach (string person in people)
            {
                // если строка начинается на букву T, добавляем в список
                if (person.ToUpper().StartsWith("T"))
                    selectedPeople.Add(person);
            }

            // сортируем список
            selectedPeople.Sort();

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}
