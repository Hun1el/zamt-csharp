using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Тег <summary> добавляет краткие сведения о типе или члене класса.
// Тег <summary> имеет важное значение. Рекомендуется всегда использовать его, так как 
// его содержимое — основной источник информации о типе или члене в IntelliSense либо 
// справочном документе по API.

// Тег <returns> описывает возвращаемое значение объявления метода. 

// https://docs.microsoft.com/ru-ru/dotnet/csharp/codedoc

namespace doc_example
{
    /// <summary>
    /// The main Math class.
    /// Contains all methods for performing basic math functions.
    /// </summary>
    public class MyMath
    {
        // Adds two integers and returns the result
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        public static int Add(int a, int b)
        {
            // If any parameter is equal to the max value of an integer
            // and the other is greater than zero
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // ...
    }
}
