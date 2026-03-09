using System.Windows;

namespace SystemResources
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label1.Foreground = SystemColors.ActiveCaptionBrush;
        }
    }
}