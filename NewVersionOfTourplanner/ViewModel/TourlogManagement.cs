using NewVersionOfTourplanner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.ViewModel
{
    public class TourlogManagement
    {
        public ObservableCollection<TourLog> TourLogs { get; set; } = new ObservableCollection<TourLog>();
        public TourlogManagement()
        {
            TourLog tourLog = new TourLog(new DateTime(2024, 10, 27, 12, 00, 00), "comment", "easy", 2, new TimeSpan(10, 00, 00), "like");
            AddTourLog(tourLog);
        }

        public void AddTourLog(TourLog tourLog)
        {
            TourLogs.Add(tourLog);
        }
    }
}
