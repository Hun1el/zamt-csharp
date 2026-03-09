using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** РАБОТА СО СТРОКАМИ *****\n");
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            StringsAreImmutable();
            FunWithStringBuilder();
            StringInterpolation();
            Console.ReadLine();
        }

        #region String basics
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Основы работы со строками:");

            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);

            //длинна строки
            Console.WriteLine("firstName has {0} characters.", firstName.Length);

            //в верхний регистр
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());

            //в нижний регистр
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());

            //содержится ли в строке указанная подстрока
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));

            //замена символов
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));

            //удаление символов
            Console.WriteLine("New first name: {0}", firstName.Remove(2,2));

            //переводим строку в массив символов
            firstName = "Programming";
            char[] a = firstName.ToCharArray();
            Console.WriteLine("New first name: {0}", a);
            Console.WriteLine();
        }
        #endregion

        #region Concatenation
        static void StringConcatenation()
        {
            //конкатенация строк
            Console.WriteLine("=> Конкатенация строк:");
            string s1 = "Programming the ";
            string s2 = "ЗАМТ";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        #endregion

        #region Escape Chars
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape символы:\a");

            //табуляция
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);

            //аудиосигнал
            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");

            // добавляет 4 пустых линии + сигнал
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();

            // дословное воспроизведение строк
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            // можно и так
            string myLongString = @"This is a very
                 very
                      very
                           long string";
            Console.WriteLine(myLongString);
            Console.WriteLine();

            //дублируем знак "
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }
        #endregion

        #region Immutable test
        static void StringsAreImmutable()
        {
            Console.WriteLine("=> Неизменяемость строк:\a");
            //строки являются неизменяемыми!!!!!
            //начальное значение строки
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            //переводим в верхний регистр
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            //но строка осталась неизменной
            Console.WriteLine("s1 = {0}", s1);

            //и еще пример
            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }
        #endregion

        #region StringBuilder
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Использование StringBuilder:");

            // Make a StringBuilder with an initial size of 256.
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good and Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
        #endregion

        #region String interpolation
        static void StringInterpolation()
        {
            //интерполяция строк
            int age = 4;
            string name = "Soren";

            //что было раньше...
            string greeting = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);

            //... и что сейчас
            string greeting2 = $"\tHello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
        #endregion
    }
}
