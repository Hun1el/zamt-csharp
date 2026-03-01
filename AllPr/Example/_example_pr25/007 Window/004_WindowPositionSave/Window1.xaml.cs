using System;
using System.Windows;
using System.ComponentModel;

namespace _006_WindowPositionSave
{
    // Данное приложение для хранения данных использует settings файл.
    // Есть два вида настроек settings:
    // 1) Application-scoped - эти значения не могут меняться на этапе выполнения. Обычно это
    // ConnectionString или подобные значения.
    // 2) User-scoped - эти значения могут меняться в процессе выполнения приложения (например, размеры окна, цвет и т.д.)

    // Файл settings находится в папке Properties в Solution Explorer

    // Данные самого приложения, записанные в процессе выполнения, находятся в папке C:\Documents and Settings\AppData\AppName

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // Вешаем обработчик на событие перед закрытием окна.
            Closing += new CancelEventHandler(Window1_Closing);

            // Восстанавливаем позицию на экране.
            Left = Properties.Settings.Default.WindowPosition.Left;
            Top = Properties.Settings.Default.WindowPosition.Top;

            // Востанавливаем размеры окна.
            Width = Properties.Settings.Default.WindowPosition.Width;
            Height = Properties.Settings.Default.WindowPosition.Height;

            // Востанавливаем заголовок окна.
            Title = Properties.Settings.Default.Title;
        }

        private void Window1_Closing(object sender, CancelEventArgs e)
        {
            // RestoreBounds - Возвращает размер и расположение окна перед тем как оно было свернуто или развернуто.
            Properties.Settings.Default.WindowPosition = this.RestoreBounds;

            //// ОШИБКА! Настройки Application-scoped нельзя изменить.
            //Properties.Settings.Default.Title = Title;

            // Сохранение настроек.
            Properties.Settings.Default.Save();
        }
    }
}


