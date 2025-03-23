using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.Model
{
    public class Tour : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private string from;
        private string to;
        private string transportType;
        private int tourDistance;
        private TimeSpan estimatedTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        { get => name; set { if (name != value) { name = value; OnPropertyChanged(nameof(Name)); } } }
        public string Description
        { get => description; set { if (description != value) { description = value; OnPropertyChanged(nameof(Description)); } } }
        public string From
        { get => from; set { if (from != value) { from = value; OnPropertyChanged(nameof(From)); } } }
        public string To
        { get => to; set { if (to != value) { to = value; OnPropertyChanged(nameof(To)); } } }
        public string TransportType
        { get => transportType; set { if (transportType != value) { transportType = value; OnPropertyChanged(nameof(TransportType)); } } }
        public int TourDistance
        { get => tourDistance; set { if (tourDistance != value) { tourDistance = value; OnPropertyChanged(nameof(TourDistance)); } } }
        public TimeSpan EstimatedTime
        { get => estimatedTime; set { if (estimatedTime != value) { estimatedTime = value; OnPropertyChanged(nameof(EstimatedTime)); } } }
        public Tour(string name, string description, string from, string to, string transportType, int tourDistance, TimeSpan estimatedTime)
        {
            this.Name = name;
            this.Description = description;
            this.From = from;
            this.To = to;
            this.TransportType = transportType;
            this.TourDistance = tourDistance;
            this.EstimatedTime = estimatedTime;
        }
        public Tour()
        { }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
