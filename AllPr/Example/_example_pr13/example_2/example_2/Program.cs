using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Управление доступом - в языке C# организуется с помощью четырех модификаторов
//доступа: public, private, protected и internal.

namespace example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();

            // Доступ к членам alpha и beta данного класса
            // разрешен только посредством его методов.
            ob.SetAlpha(-99);
            ob.SetBeta(19);
            Console.WriteLine("ob.alpha равно " + ob.GetAlpha());
            Console.WriteLine("ob.beta равно " + ob.GetBeta());

            // Следующие виды доступа к членам alpha и beta
            // данного класса не разрешаются.
            //ob.alpha = 10; // Ошибка! alpha - закрытый член!
            //ob.beta =9; // Ошибка! beta - закрытый член!

            // Член gamma данного класса доступен непосредственно,
            // поскольку он является открытым.
            ob.gamma = 99;

        }
    }
}
