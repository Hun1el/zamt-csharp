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

        class Lorry : Car
        {
            public int capacity;

            public Lorry(string brand, int cylinder, int power, int capacity) : base(brand, cylinder, power)
            {
                if (capacity <= 0)
                {
                    Console.WriteLine("Грузоподъемность должна быть больше 0.");
                }

                Console.WriteLine($"Создан грузовик: {brand}, Цилиндров: {cylinder}, Мощность: {power} л.с., Грузоподъемность: {capacity} кг.");
            }

            public void NewbrandAndCapacity(string newBrand, int newCapacity)
            {
                if (newCapacity <= 0)
                {
                    Console.WriteLine("Грузоподъемность должна быть больше 0.");
                    return;
                }

                brand = newBrand;
                capacity = newCapacity;

                Console.WriteLine($"Обновлённые данные грузовика: Марка: {brand}, Грузоподъемность: {capacity} кг.");
            }
        }

        static void Main(string[] args)
        {
            // Задание 1
            while (true)
            {
                try
                {
                    Console.WriteLine("Задание 1.");
                    Console.WriteLine("Введите марку автомобиля:");
                    string brand = Console.ReadLine();

                    int cylinders = Try("\nВведите количество цилиндров:");
                    int power = Try("\nВведите мощность двигателя (л.с.):");

                    Car car = new Car(brand, cylinders, power);

                    Console.WriteLine("Изменить мощность двигателя:");
                    int newpower = Try("Введите новую мощность:");
                    car.Newpower(newpower);
                    break;
                }
                catch (FormatException ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
                catch (ArgumentException ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
            }
            Console.ReadKey();
        }

        static int Try(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                int result = Convert.ToInt32(input);

                if (result > 0)
                {
                    return result;
                }
                Console.WriteLine("Введите число больше 0.");
            }
        }
    }
}
