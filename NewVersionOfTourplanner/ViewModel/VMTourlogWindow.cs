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
        private int selectedIndex;
        public string SelectedItem
        {
            get => selectedItem; set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem)); DataManagement.GetLogsBasedOnTourname(SelectedItem);
            }
        }
        public int SelectedIndex { get => selectedIndex; set {selectedIndex = value; OnPropertyChanged(nameof(SelectedIndex)); } }
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

        public ICommand RemoveLogs
        {
            get 
            {
                return new Command(obj =>
                {
                    if(SelectedIndex >= 0)
                    {
                        DataManagement.DeleteTourLogBasedOnIndex(SelectedIndex);
                        DataManagement.GetLogsBasedOnTourname(SelectedItem);
                    }
                });
            }
        }
    }
}
