using Windows.UI.Xaml.Controls;
using LearningManagementSystem.GUI.UWP.Core;

namespace LearningManagementSystem.GUI.UWP.Views
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            var mainViewModel = new MainPageViewModel();
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Dashboard",
                DestinationPage = typeof(DashboardPage),
                Symbol = Symbol.DockBottom
            });
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Dedlines",
                DestinationPage = typeof (DedlinesPage),
                Symbol = Symbol.CalendarDay
            });
            mainViewModel.MenuItems.Add(new SimpleNavMenuItem
            {
                Label = "Project Files",
                DestinationPage = typeof (ProjectFilesPage),
                Symbol = Symbol.OpenFile
            });
            DataContext = mainViewModel;
        }
    }
}