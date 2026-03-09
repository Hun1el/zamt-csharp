using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var17
{
    /// <summary>
    /// Класс для проверки, лежит ли точка в первой или третьей.
    /// </summary>
    public class Task01
    {
        /// <summary>
        /// Проверка на условие.
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <returns>Истинность или ложность</returns>
        public static bool FirstOrThree(int x, int y)
        {
            return (x > 0 && y > 0) || (x < 0 && y < 0);
        }
    }
}
