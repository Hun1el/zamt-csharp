using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _002_DragAndDrop
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void lblSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // sender – объект, на котором произошло данное событие.
            Label lbl = sender as Label;

            // Создаем источник.
            // Копируем содержимое метки Drop.
            // 1 параметр: Элемент управления, который будет источником.
            // 2 параметр: Данные, которые будут перемещаться.
            // 3 параметр: Эффект при переносе.

            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
        }

        // Событие инициируется в момент бросания перетягиваемого элемента на целевой элемент.
        private void lblTarget_Drop(object sender, DragEventArgs e)
        {
            // Считываем содержимое кэша Drag&Drop и указываем какой тип данных надо считать.
            ((Label)sender).Content = e.Data.GetData(DataFormats.Text);
        }
    }
}


