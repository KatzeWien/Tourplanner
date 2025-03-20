using NewVersionOfTourplanner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.ViewModel
{
    public class AllDataManagement
    {
        public ObservableCollection<Tour> Tours {  get; set; } = new ObservableCollection<Tour>();
        public ObservableCollection<TourLog> Logs { get; set; } = new ObservableCollection<TourLog>();
        public AllDataManagement()
        {
            TourLog tourLog = new TourLog(new DateTime(2024, 10, 27, 12, 00, 00), "comment", "easy", 2, new TimeSpan(10, 00, 00), "like");
            AddTourLog(tourLog);
            Tour test = new Tour("name2", "desc", "flo", "dorf", "bim", 5, new TimeSpan(10, 00, 00));
            AddTour(test);
        }
        public void AddTourLog(TourLog tourLog)
        {
            Logs.Add(tourLog);
        }

        public void AddTour(Tour tour)
        {
            Tours.Add(tour);
        }

        public void DeleteTour(Tour tour)
        {
            Tours.Remove(tour);
        }
    }
}
