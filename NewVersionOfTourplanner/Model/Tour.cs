using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfTourplanner.Model
{
    public class Tour
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string TransportType { get; set; }
        public int TourDistance { get; set; }
        public TimeSpan EstimatedTime { get; set; }
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
    }
}
