using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.Model
{
    public class TourLog : INotifyPropertyChanged

    {
        private string nameOfTour;
        private DateTime date;
        private string comment;
        private string difficulty;
        private int totalDistance;
        private TimeSpan totalTime;
        private string rating;

        public event PropertyChangedEventHandler PropertyChanged;

        public string NameOfTour { get => nameOfTour; set { nameOfTour = value; OnPropertyChanged(nameof(NameOfTour)); } }
        public DateTime Date { get => date; set { date = value; OnPropertyChanged(nameof(Date)); } }
        public string Comment { get => comment; set { comment = value; OnPropertyChanged(nameof(Comment)); } }
        public string Difficulty { get => difficulty; set { difficulty = value; OnPropertyChanged(nameof(Difficulty)); } }
        public int TotalDistance { get => totalDistance; set { totalDistance = value; OnPropertyChanged(nameof(TotalDistance)); } }
        public TimeSpan TotalTime { get => totalTime; set { totalTime = value; OnPropertyChanged(nameof(TotalTime)); } }
        public string Rating { get => rating; set { rating = value; OnPropertyChanged(nameof(Rating)); } }
        public TourLog(string nameOfTour, DateTime date, string comment, string difficulty, int totalDistance, TimeSpan totalTime, string rating)
        {
            this.NameOfTour = nameOfTour;
            this.Date = date;
            this.Comment = comment;
            this.Difficulty = difficulty;
            this.TotalDistance = totalDistance;
            this.TotalTime = totalTime;
            this.Rating = rating;
        }
        public TourLog()
        { }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
