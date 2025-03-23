using NewVersionOfTourplanner.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewVersionOfTourplanner.View
{
    /// <summary>
    /// Interaktionslogik für ChangeTourLogs.xaml
    /// </summary>
    public partial class ChangeTourLogs : Window
    {
        public ChangeTourLogs(AllDataManagement dataManagement, int indexSelectedTour)
        {
            InitializeComponent();
            var viewModel = new ViewModel.VMChangeTourLog(dataManagement, indexSelectedTour);
            viewModel.SaveSucceeded += (s, e) =>
            {
                this.DialogResult = true;
                this.Close();
            };
            this.DataContext = viewModel;
        }
    }
}
