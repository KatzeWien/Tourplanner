using NewVersionOfTourplanner.Model;
using NewVersionOfTourplanner.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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
        private AllDataManagement management;
        public ObservableCollection<Tour> Tours { get; set; }
        private Tour tour;
        public TourDetails(AllDataManagement management, Tour tour)
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
            bool isInputValid = true;
            string inputName = name.Text;
            string inputDescription = description.Text;
            string inputFrom = from.Text;
            string inputTo = to.Text;
            string inputTransporttype = transporttype.Text;
            string inputDistance = tourdistance.Text;
            int distance;
            if (!int.TryParse(inputDistance, out distance))
            {
                MessageBox.Show("Only numbers are valid");
                isInputValid = false;
                return;
            }
            string inputTime = estimatedtime.Text;
            TimeSpan timeSpan;
            if(!TimeSpan.TryParse(inputTime, out timeSpan))
            {
                MessageBox.Show("Only numbers are valid");
                isInputValid = false;
                return;
            }
            if (inputTime == "" || inputDescription == "" || inputFrom == "" || inputTo == "" || inputTransporttype == "")
            {
                MessageBox.Show("All fields needs inputs");
                isInputValid = false;
                return;
            }
            if (isInputValid == true)
            {
                ChangeData(inputName, inputDescription, inputFrom, inputTo, inputTransporttype, distance, timeSpan);
            }
        }

        public void ChangeData(string name, string description, string from, string to, string transporttype, int distance, TimeSpan timeSpan)
        {
            tour.Name = name;
            tour.Description = description;
            tour.From = from;
            tour.To = to;
            tour.TransportType = transporttype;
            tour.TourDistance = distance;
            tour.EstimatedTime = timeSpan;
        }
    }
}
