using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace LearningManagementSystem.GUI.UWP.Views
{
    public sealed partial class DashboardPage : Page
    {
        public DashboardPage()
        {
            InitializeComponent();

            var r = new Random();

            var lst = new List<Usr>();

            lst.Add(new Usr() { ImageUri = new Uri($@"ms-appx://LearningManagementSystem.UWP.GUI/Assets/gas.jpg"),    FullName = "Gustavo Fring", StudentID = r.Next(1000000000, int.MaxValue).ToString() });
            lst.Add(new Usr() { ImageUri = new Uri($@"ms-appx://LearningManagementSystem.UWP.GUI/Assets/emilia.jpg"), FullName = "Emilia Clarke", StudentID = r.Next(1000000000, int.MaxValue).ToString() });
            lst.Add(new Usr() { ImageUri = new Uri($@"ms-appx://LearningManagementSystem.UWP.GUI/Assets/margot.png"), FullName = "Margot Robbie", StudentID = r.Next(1000000000, int.MaxValue).ToString() });

            gridview.ItemsSource = lst;
        }
    }

    public class Usr
    {
        public Uri ImageUri { get; set; }
        public string FullName { get; set; }
        public string StudentID { get; set; }
    }
}
