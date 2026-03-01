// Задание 01
// Создать базовый класс Саr (машина), характеризуемый торговой маркой (строка), числом цилиндров, мощностью. Определить методы переназначения и изменения мощности.
// Создать производный класс Lorry (грузовик), характеризуемый грузоподъемностью кузова. Определить функции переназначения марки и изменения грузоподъемности.

// Задание 02
// Создать класс Liquid (жидкость), имеющий поля названия и плотности. Определить методы переназначения и изменения плотности.
// Создать производный класс Alcohol (спирт), имеющий крепость. Определить методы переназначения и изменения крепости.

// Задание 03
// Создать класс Man (человек), с полями: имя, фамилия, возраст, пол и вес. Определить методы переназначения имени, изменения возраста и изменения веса.
// Создать производный класс Student, имеющий поля года обучения и специальность обучения. Определить методы переназначения и увеличения года обучения.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15
{
    internal class Program
    {
        class Car
        {
            public string brand;
            public int cylinder;
            public int power;

            public Car(string brand, int cylinder, int power)
            {
                if (cylinder <= 0)
                {
                    Console.WriteLine("Количество цилиндров должно быть больше 0.");
                }
                else if (power <= 0)
                {
                    Console.WriteLine("Мощность должна быть больше 0.");
                }

                Console.WriteLine($"\nСоздан автомобиль: {brand}, Цилиндров: {cylinder}, Мощность: {power} л.с.");
            }

            public void Newpower(int newpower)
            {
                if (newpower <= 0)
                {
                    Console.WriteLine("Мощность должна быть больше 0.");
                }
                else
                {
                    power = newpower;
                    Console.WriteLine($"Мощность автомобиля {brand} изменена на {power} л.с.");
                }
            }
        }

        static void Main(string[] args)
        {
            // Задание 1

        }
    }
}
