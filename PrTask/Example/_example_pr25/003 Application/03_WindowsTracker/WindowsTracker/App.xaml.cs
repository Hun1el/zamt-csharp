using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WindowsTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private List<Document> documents = new List<Document>();
        public List<Document> Documents
        {
            get { return documents; }
            set { documents = value; }
        }
    }
}
