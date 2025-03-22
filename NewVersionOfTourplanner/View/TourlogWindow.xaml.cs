using NewVersionOfTourplanner.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewVersionOfTourplanner.View
{
    /// <summary>
    /// Interaktionslogik für TourlogWindow.xaml
    /// </summary>
    public partial class TourlogWindow : Page
    {
        private string tourname = "";
        public TourlogWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddLogs_Click(object sender, RoutedEventArgs e)
        {
            if (tourname != "")
            {
                var sharedContext = DataContext as AllDataManagement;
                AddTourLogs addTour = new AddTourLogs(sharedContext, tourname);
                addTour.ShowDialog();
            }
        }

        private void choosentour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sharedContext = DataContext as AllDataManagement;
            tourname = (string)((System.Windows.Controls.ComboBox)sender).SelectedItem;
            sharedContext.GetLogsBasedOnTourname(tourname);
        }

        private void ButtonDeleteLog_Click(object sender, RoutedEventArgs e)
        {
            var sharedContext = DataContext as AllDataManagement;
            var listview = logOutput.FindName("logView") as ListView;
            int indexLog = listview.SelectedIndex;
            if (indexLog >= 0)
            {
                sharedContext.DeleteTourLogBasedOnIndex(indexLog);
                sharedContext.GetLogsBasedOnTourname(tourname);
            }
        }

        private void ButtonChangeLog_Click(object sender, RoutedEventArgs e)
        {
            var sharedContext = DataContext as AllDataManagement;
            var listview = logOutput.FindName("logView") as ListView;
            int indexLog = listview.SelectedIndex;
            if (indexLog >= 0)
            {
                ChangeTourLogs changeTourLogs = new ChangeTourLogs();
                changeTourLogs.ShowDialog();
            }
        }
    }
}
