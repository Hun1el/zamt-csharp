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
using LocalizatorHelper;

namespace WpfLocalizationSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ResourceManagerService.RegisterManager("MainWindowRes", MainWindowRes.ResourceManager, true);
        }

        private void RuMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceManagerService.ChangeLocale("ru-RU");
        }

        private void EnMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceManagerService.ChangeLocale("en-US");
        }
    }
}
