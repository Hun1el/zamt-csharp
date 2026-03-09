using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Именованные аргументы

namespace example_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NamedArgsDemo NAD = new NamedArgsDemo();

            // Ниже демонстрируются разные способы вызова метода IsFactor().

            // Вызов с использованием позиционных аргументов.
            if (NAD.IsFactor(10, 2))
                Console.WriteLine("2 - множитель 10.");

            // Вызов с использованием именованных аргументов.
            if (NAD.IsFactor(val: 10, divisor: 2))
                Console.WriteLine("2 - множитель 10.");

            // Для именованного аргумента порядок указания не имеет значения.
            if (NAD.IsFactor(divisor: 2, val: 10))
                Console.WriteLine("2 - множитель 10.");

            // Применить как позиционный, так и именованный аргумент.
            if (NAD.IsFactor(10, divisor: 2))
                Console.WriteLine("2 - множитель 10.");
        }
    }
}
