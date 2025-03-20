using NewVersionOfTourplanner.Model;
using NewVersionOfTourplanner.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaktionslogik für ListOfTours.xaml
    /// </summary>
    public partial class ListOfTours : UserControl
    {
        public ListOfTours()
        {
            InitializeComponent();
        }

        private void ButtonOpenDetails_Click(object sender, RoutedEventArgs e)
        {
            var sharedContext = DataContext as AllDataManagement;
            var button = sender as Button;
            var content = button.Content;
            string name = content as string;
            Tour tour = sharedContext.Tours.FirstOrDefault(p => p.Name == name);
            TourDetails tourDetails = new TourDetails(sharedContext, tour);
            tourDetails.ShowDialog();
        }
    }
}
