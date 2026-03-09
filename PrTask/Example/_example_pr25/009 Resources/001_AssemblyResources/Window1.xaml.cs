using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace AssemblyResources
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void cmdPlay_Click(object sender, RoutedEventArgs e)
        {
            // Использование объекта BitmapImage, который поддерживает работу с ресурсами.
            // Относительный путь к ресурсу.
            img.Source = new BitmapImage(new Uri("images/winter.jpg", UriKind.Relative));
            // Полный путь к ресурсу.
            //img.Source = new BitmapImage(new Uri("pack://application:,,,/images/winter.jpg", UriKind.Absolute));
        }

        // Чтение ресурсов.
        private void buttonGetResource_Click(object sender, RoutedEventArgs e)
        {
            // Получение нужного ресурса.
            StreamResourceInfo resInfo = Application.GetResourceStream(new Uri("test.txt", UriKind.Relative));
            MessageBox.Show("Тип ресурса: " + resInfo.ContentType);

            // Чтение данных.
            StreamReader reader = new StreamReader(resInfo.Stream, System.Text.Encoding.Default);
            string textFromRes = reader.ReadToEnd();
            reader.Close();
            MessageBox.Show(textFromRes);
        }

        // Получение всех ресурсов.
        private void buttonGetAllResources_Click(object sender, RoutedEventArgs e)
        {
            Assembly assembly = Assembly.GetAssembly(this.GetType());
            string resourceName = assembly.GetName().Name + ".g";

            // Позволяет получить доступ к ресурсу (на основе культуры) на этапе выполнения.
            ResourceManager rm = new ResourceManager(resourceName, assembly);
            using (ResourceSet set = rm.GetResourceSet(CultureInfo.CurrentCulture, true, true))
            {
                string result = string.Empty;
                foreach (DictionaryEntry item in set)
                {
                    result += item.Key.ToString() + Environment.NewLine;
                }
                MessageBox.Show(result);
            }
        }
    }
}