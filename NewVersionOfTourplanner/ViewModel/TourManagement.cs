using NewVersionOfTourplanner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.ViewModel
{
    public class TourManagement
    {
        public ObservableCollection<Tour> Tours { get; set; } = new ObservableCollection<Tour>();
        public TourManagement()
        {
            Tour test = new Tour("name2", "desc", "flo", "dorf", "bim", 5, new TimeSpan(10, 00, 00));
            AddTour(test);
        }

        public void AddTour(Tour tour)
        {
            Tours.Add(tour);
        }
    }
}
