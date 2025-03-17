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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewVersionOfTourplanner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TourManagement Management { get; set; }
        public TourlogManagement Tourlog {  get; set; }
        public AllDataManagement AllDataManagement { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Management = new TourManagement();
            Tourlog = new TourlogManagement();
            AllDataManagement = new AllDataManagement();
            /*tourconfig.DataContext = Management;
            listOfTours.DataContext = Management;
            tourlog.DataContext = Tourlog;*/
            MainFrame.DataContext = AllDataManagement;
        }
    }
}
