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
        public ObservableCollection<string> TourNames { get; set; } = new ObservableCollection<string>();
        public AllDataManagement()
        {
            TourLog tourLog = new TourLog("Test2", new DateTime(2024, 10, 27, 12, 00, 00), "comment", "easy", 2, new TimeSpan(10, 00, 00), "like");
            AddTourLog(tourLog);
            Tour test = new Tour("name2", "desc", "flo", "dorf", "bim", 5, new TimeSpan(10, 00, 00));
            AddTour(test);
            GetAllTourNames();
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

        public void GetAllTourNames()
        {
            if (TourNames.Count > 0)
            {
                TourNames.Clear();
            }
            foreach (var tourname in Tours.Select(p => p.Name))
            {
                TourNames.Add(tourname);
            }
        }
    }
}
