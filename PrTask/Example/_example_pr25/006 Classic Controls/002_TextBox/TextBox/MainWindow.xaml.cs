using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // Если нет выделенного текста, выполняем возврат.
            if (txtSelection == null)
            {
                return;
            }

            // Иначе считываем выделенный текст.
            txtSelection.Text = String.Format(
                "Выбрано с позиции {0}; количество символов --  {1}; текст -- \"{2}\"",
                txt.SelectionStart, 
                txt.SelectionLength, 
                txt.SelectedText);
        }
    }
}
