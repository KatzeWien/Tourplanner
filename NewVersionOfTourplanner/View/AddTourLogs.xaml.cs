using NewVersionOfTourplanner.Model;
using NewVersionOfTourplanner.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaktionslogik für AddTourLogs.xaml
    /// </summary>
    public partial class AddTourLogs : Window
    {
        private AllDataManagement management;
        private string tourName;
        public AddTourLogs(AllDataManagement management, string tourName)
        {
            InitializeComponent();
            var viewModel = new ViewModel.VMAddTourLog(management, tourName);
            viewModel.SaveSucceeded += (s, e) =>
            {
                this.DialogResult = true;
                this.Close();
            };
            this.DataContext = viewModel;
        }
    }
}
