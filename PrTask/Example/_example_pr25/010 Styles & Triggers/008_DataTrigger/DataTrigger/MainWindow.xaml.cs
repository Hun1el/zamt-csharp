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
using System.Collections.ObjectModel;

namespace DataTrigger
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Resources.Add("PlacesData", new Countries()); 

        }
    }

    class Countries : ObservableCollection<Country>
    {
        public Countries()
        {   
            this.Add(new Country("Ukraine", "UA"));
            this.Add(new Country("Russia", "RU"));
            this.Add(new Country("United States of America", "USA")); 
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Country()
        {

        }

        public Country(string name, string shortName)
        {
            Name = name;
            ShortName = shortName;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
