using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.Model
{
    public class TourLog
    {
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public string Difficulty { get; set; }
        public int TotalDistance { get; set; }
        public TimeSpan TotalTime { get; set; }
        public string Rating { get; set; }
        public TourLog(DateTime date, string comment, string difficulty, int totalDistance, TimeSpan totalTime, string rating)
        {
            this.Date = date;
            this.Comment = comment;
            this.Difficulty = difficulty;
            this.TotalDistance = totalDistance;
            this.TotalTime = totalTime;
            this.Rating = rating;
        }
    }
}
