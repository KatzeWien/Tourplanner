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
using System.Windows.Shapes;

namespace NewVersionOfTourplanner.View
{
    /// <summary>
    /// Interaktionslogik für TourDetails.xaml
    /// </summary>
    public partial class TourDetails : Window
    {
        private TourManagement management;
        public ObservableCollection<Tour> Tours { get; set; }
        private Tour tour;
        public TourDetails(TourManagement management, Tour tour)
        {
            InitializeComponent();
            this.management = management;
            Tours = this.management.Tours;
            this.tour = tour;
            this.DataContext = this.tour;
        }

        public void ButtonDeleteTour_Click(object sender, RoutedEventArgs e)
        {
            this.management.DeleteTour(this.tour);
            this.Close();
        }

        public void ButtonCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ButtonChangeTour_Click(object sender, RoutedEventArgs e)
        {
            tour.Name = name.Text;
            tour.Description = description.Text;
            tour.From = from.Text;
            tour.To = to.Text;
            tour.TransportType = transporttype.Text;
            string inputDistance = tourdistance.Text;
            int distance;
            int.TryParse(inputDistance, out distance);
            tour.TourDistance = distance;
            string inputTime = estimatedtime.Text;
            TimeSpan timeSpan;
            TimeSpan.TryParse(inputTime, out timeSpan);
            tour.EstimatedTime = timeSpan;
        }
    }
}
