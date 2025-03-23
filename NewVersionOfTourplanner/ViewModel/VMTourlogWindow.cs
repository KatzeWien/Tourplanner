using NewVersionOfTourplanner.Commands;
using NewVersionOfTourplanner.Model;
using NewVersionOfTourplanner.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewVersionOfTourplanner.ViewModel
{
    public class VMTourlogWindow : INotifyPropertyChanged
    {
        public AllDataManagement DataManagement { get; }
        public ObservableCollection<string> TourNames { get; }
        public ObservableCollection<TourLog> SpecialLogs { get; set; }
        private string selectedItem;
        public string SelectedItem
        {
            get => selectedItem; set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem)); DataManagement.GetLogsBasedOnTourname(SelectedItem);
            }
        }
        public VMTourlogWindow(AllDataManagement dataManagement)
        {
            this.DataManagement = dataManagement;
            this.TourNames = DataManagement.TourNames;
            this.SpecialLogs = DataManagement.SpecialLogs;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand AddLogs
        {
            get
            {
                return new Command(obj =>
                {
                    if (SelectedItem != "")
                    {
                        AddTourLogs addTour = new AddTourLogs(DataManagement, SelectedItem);
                        addTour.ShowDialog();
                    }
                });
            }
        }
    }
}
