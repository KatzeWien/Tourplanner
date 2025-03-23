﻿using NewVersionOfTourplanner.Commands;
using NewVersionOfTourplanner.Model;
using NewVersionOfTourplanner.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewVersionOfTourplanner.ViewModel
{
    public class VMTourWindow
    {
        public AllDataManagement DataManagement { get; }
        public ObservableCollection<Tour> Tours { get; set; }
        private string name;

        public string Name { get => name; }
        public VMTourWindow(AllDataManagement dataManagement)
        {
            DataManagement = dataManagement;
            Tours = dataManagement.Tours;
        }
        public ICommand AddTour
        {
            get
            {
                return new Command(obj =>
                {
                    AddTour addTour = new AddTour(DataManagement);
                    addTour.ShowDialog();
                });
            }
        }

        public ICommand OpenDetails
        {
            get
            {
                return new Command(obj =>
                {
                    Tour tour = DataManagement.Tours.FirstOrDefault(p => p.Name == obj.ToString());
                    TourDetails tourDetails = new TourDetails(DataManagement, tour);
                    tourDetails.ShowDialog();
                });
            }
        }
    }
}
