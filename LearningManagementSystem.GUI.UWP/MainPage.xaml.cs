using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LearningManagementSystem.GUI.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentsListBoxItem.IsSelected) { ResultTextBlock.Text = "Students"; }
            if (StuffListBoxItem.IsSelected) { ResultTextBlock.Text = "Stuff"; }
            if (ScheduleListBoxItem.IsSelected) { ResultTextBlock.Text = "Schedule"; }
            if (TeachersListBoxItem.IsSelected) { ResultTextBlock.Text = "Teachers"; }
            else if (SearchListBoxItem.IsSelected) { ResultTextBlock.Text = "Search"; }
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
    }
}
