using NewVersionOfTourplanner.Model;
using NewVersionOfTourplanner.ViewModel;
using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für AddTourLogs.xaml
    /// </summary>
    public partial class AddTourLogs : Window
    {
        private AllDataManagement management;
        private string tourName;
        public AddTourLogs(AllDataManagement management, string tourName)
        {
            InitializeComponent();
            this.management = management;
            this.tourName = tourName;
        }

        private void addValuesBtn_Click(object sender, RoutedEventArgs e)
        {
            string InputDate = inputDate.Text;
            string comment = Comment.Text;
            string difficulty = Difficulty.Text;
            string inputTotalDistance = TotalDistance.Text;
            string inputTotalTime = TotalTime.Text;
            string rating = Rating.Text;
            int totalDistance;
            TimeSpan totalTime;
            DateTime date;
            if (!int.TryParse(inputTotalDistance, out totalDistance))
            {
                MessageBox.Show("Only numbers are valid");
                return;
            }
            if(inputTotalTime.Contains(":"))
            {
                if (!TimeSpan.TryParse(inputTotalTime, out totalTime))
                {
                    MessageBox.Show("Only valid time hh:mm or hh!");
                    return;
                }
            }
            else
            {
                if(int.TryParse(inputTotalTime, out int hours))
                {
                    totalTime = TimeSpan.FromHours(hours);
                }
                else
                {
                    MessageBox.Show("Only valid time hh:mm or hh!");
                    return;
                }
            }
            if (!DateTime.TryParse(InputDate, out date))
            {
                MessageBox.Show("Only valid date");
                return;
            }
            if (comment == "" || difficulty == "" || rating == "")
            {
                MessageBox.Show("All fields needs inputs");
                return;
            }
            TourLog tourlog = new TourLog(this.tourName, date, comment, difficulty, totalDistance, totalTime, rating);
            this.management.AddTourLog(tourlog);
            this.management.GetLogsBasedOnTourname(this.tourName);
            this.Close();
        }
    }
}
