using System;

// Доступ к закрытым членам класса не наследуется.
// Этот пример кода не подлежит компиляции - будет ошибка!.

namespace ex02_inherit
{
    class Program
    {
        class TwoDShape
        {
            double Width; // теперь это закрытая переменная
            double Height; // теперь это закрытая переменная
            public void ShowDim()
            {
                Console.WriteLine("Ширина и высота равны " +
                                Width + " и " + Height);
            }
        }

        // Класс Triangle, производный от класса TwoDShape.
        class Triangle : TwoDShape
        {
            public string Style; // тип треугольника
                                 // Возвратить площадь треугольника.
            public double Area()
            {
                return Width * Height / 2; // Ошибка, доступ к закрытому
                                           // члену класса запрещен
            }
            // Показать тип треугольника.
            public void ShowStyle()
            {
                Console.WriteLine("Треугольник " + Style);
            }
        }

        static void Main()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "равнобедренный";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "прямоугольный";

            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь равна " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь равна " + t2.Area());
        }
    }
}
