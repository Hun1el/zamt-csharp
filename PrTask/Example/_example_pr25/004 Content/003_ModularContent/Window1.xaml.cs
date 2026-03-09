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

namespace _002_ModularContent
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // Вешаем обработчик на события (Checked и Unchecked) всех CheckBox(ов), которые находятся внутри окна.
            AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(chk_Checked));
            AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(chk_Unchecked));
        }

        private void chk_Checked(object sender, RoutedEventArgs e)
        {
            // Копируем ссылку на используемый CheckBox.
            // OriginalSource - свойство содержащее отправителя события.
            CheckBox chk = e.OriginalSource as CheckBox;

            // При помощи системного класса LogicalTreeHelper и его метода FindLogicalNode(),
            // можно выполнить поиск какого либо элемента в XAML коде элемента переданого в аргументы по имени.            
            DependencyObject dpObj = LogicalTreeHelper.FindLogicalNode(panel, chk.Content.ToString());

            // Показываем элемент который мы получили. (Panel1, Panel2, и т.д.)
            ((FrameworkElement)dpObj).Visibility = Visibility.Visible;
        }

        private void chk_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = e.OriginalSource as CheckBox;
            DependencyObject obj = LogicalTreeHelper.FindLogicalNode(panel, chk.Content.ToString());
            ((FrameworkElement)obj).Visibility = Visibility.Collapsed;
        }
    }
}
