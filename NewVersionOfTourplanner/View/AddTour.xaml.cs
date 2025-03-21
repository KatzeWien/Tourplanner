﻿using NewVersionOfTourplanner.Model;
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
using System.Windows.Shapes;

namespace NewVersionOfTourplanner.View
{
    /// <summary>
    /// Interaktionslogik für AddTour.xaml
    /// </summary>
    public partial class AddTour : Window
    {
        private AllDataManagement management;
        public AddTour(AllDataManagement management)
        {
            InitializeComponent();
            this.management = management;
        }

        private void addValuesBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string description = Description.Text;
            string from = From.Text;
            string to = To.Text;
            string transportType = TransportType.Text;
            string inputTourDistance = TourDistance.Text;
            string inputEstimatedTime = EstimatedTime.Text;
            int tourDistance;
            TimeSpan estimatedTime;
            if (!int.TryParse(inputTourDistance, out tourDistance))
            {
                MessageBox.Show("Only numbers are valid");
                return;
            }
            if (inputEstimatedTime.Contains(":"))
            {
                if (!TimeSpan.TryParse(inputEstimatedTime, out estimatedTime))
                {
                    MessageBox.Show("Only valid time hh:mm or hh!");
                    return;
                }
            }
            else
            {
                if (int.TryParse(inputEstimatedTime, out int hours))
                {
                    estimatedTime = TimeSpan.FromHours(hours);
                }
                else
                {
                    MessageBox.Show("Only valid time hh:mm or hh!");
                    return;
                }
            }
            if(name == "" || description == "" || from == "" || to == "" || transportType == "")
            {
                MessageBox.Show("All fields needs inputs");
                return;
            }
            Tour tour = new Tour(name, description, from, to, transportType, tourDistance, estimatedTime);
            this.management.AddTour(tour);
            this.management.GetAllTourNames();
            this.Close();
        }
    }
}
