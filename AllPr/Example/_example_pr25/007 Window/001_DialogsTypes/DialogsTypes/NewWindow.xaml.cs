using System;
using System.Windows;

namespace DialogsTypes
{
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        public NewWindow(string title) //: this()
        {
            InitializeComponent(); // Переопределяя конструктор мы должны вызывать метод InitializeComponent
            Title = title;
        }
    }
}
