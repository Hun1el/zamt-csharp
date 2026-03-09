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

namespace CheckBoxList
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lst_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // Если источник события CheckBox 
            if (e.OriginalSource is CheckBox)
            {
                // В ListBox выбранным элементом делаем этот CheckBox
                lst.SelectedItem = e.OriginalSource;
            }

            // SelectedIndex - позиция выбранного элемента.
            // SelectedItem - объект выбранный в списке.
            txtSelection.Text = String.Format("Позиция {0}.\r\nСостояние {1}.", 
                lst.SelectedIndex, 
                ((CheckBox)lst.SelectedItem).IsChecked);
        }

        private void cmd_CheckAllItems(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            // Проходим по всем элементам в ListBox
            foreach (CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    sb.AppendLine(item.Content + " отмечен. ");
                }
            }
            txtSelection.Text = sb.ToString();
        }
    }
}
