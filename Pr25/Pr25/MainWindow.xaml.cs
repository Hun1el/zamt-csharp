using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Task01(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(txtNumber.Text);

            if (N >= 1000 && N <= 9999)
            {
                string str = N.ToString();
                bool truefalse = str.Distinct().Count() == 4;

                if (truefalse)
                {
                    lblResult1.Text = "Все цифры различны";
                }
                else
                {
                    lblResult1.Text = "Есть повторяющиеся цифры";
                }
            }
            else
            {
                lblResult1.Text = "Введите четырехзначное число";
            }
        }

        private void Task02(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] numbers = new int[5];
                numbers[0] = Convert.ToInt32(txtNumber1.Text);
                numbers[1] = Convert.ToInt32(txtNumber2.Text);
                numbers[2] = Convert.ToInt32(txtNumber3.Text);
                numbers[3] = Convert.ToInt32(txtNumber4.Text);
                numbers[4] = Convert.ToInt32(txtNumber5.Text);

                if (numbers.Distinct().Count() != 5)
                {
                    lblResult2.Text = "Введите пять различных чисел";
                    return;
                }

                int max1 = numbers[0], max2 = int.MinValue, max3 = int.MinValue;

                foreach (int num in numbers)
                {
                    if (num > max1)
                    {
                        max3 = max2;
                        max2 = max1;
                        max1 = num;
                    }
                    else if (num > max2)
                    {
                        max3 = max2;
                        max2 = num;
                    }
                    else if (num > max3)
                    {
                        max3 = num;
                    }
                }

                int product = max1 * max2 * max3;
                lblResult2.Text = $"Произведение трех наибольших чисел: {product}";
            }
            catch
            {
                lblResult2.Text = "Ошибка ввода, введите целые числа";
            }
        }
    }
}
