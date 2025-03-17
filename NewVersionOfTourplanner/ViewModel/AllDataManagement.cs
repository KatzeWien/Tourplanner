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
        private TourlogManagement tourlog = new TourlogManagement();
        private TourManagement tour = new TourManagement();
        public ObservableCollection<Tour> Tours {  get; set; } 
        public ObservableCollection<TourLog> Logs { get; set; }
        public AllDataManagement()
        {
            this.Logs = tourlog.TourLogs;
            this.Tours = tour.Tours;
        }
    }
}
