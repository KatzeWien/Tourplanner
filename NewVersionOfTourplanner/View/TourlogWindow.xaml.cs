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
        public TourlogWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddLogs_Click(object sender, RoutedEventArgs e)
        {
            string tourname = choosentour.Text;
            if (tourname != "")
            {
                var sharedContext = DataContext as AllDataManagement;
                AddTourLogs addTour = new AddTourLogs(sharedContext, tourname);
                addTour.ShowDialog();
            }
        }
    }
}
