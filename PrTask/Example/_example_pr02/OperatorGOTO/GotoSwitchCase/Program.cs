using System;

namespace GotoSwitchCase
{
    class SwitchTest
    {
        static void Main()
        {
            Console.WriteLine("Размер кофе: 1=Маленький 2=Средний 3=Большой");
            Console.Write("Пожалуйста, сделайте выбор: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int cost = 0;
            switch (n)
            {
                case 1:
                    cost = 25; //+= 25;
                    break;
                case 2:
                    cost = 50; //+= 25;
                    break; //goto case 1;
                case 3:
                    cost = 75; //+= 50;
                    break; //goto case 1;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine($"Please insert {cost} cents.");
            }
            Console.WriteLine("Спасибо за покупку.");
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}

