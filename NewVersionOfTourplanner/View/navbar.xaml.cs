﻿using NewVersionOfTourplanner.ViewModel;
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

namespace NewVersionOfTourplanner.View
{
    /// <summary>
    /// Interaktionslogik für navbar.xaml
    /// </summary>
    public partial class navbar : UserControl
    {
        public navbar()
        {
            InitializeComponent();
        }

        private void SwitchToTour(object sender, RoutedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            var tourWindow = new TourWindow();
            tourWindow.DataContext = mainWindow.MainFrame.DataContext;
            mainWindow?.MainFrame.Navigate(tourWindow);
        }

        private void SwitchToHome(object sender, RoutedEventArgs e)
        {
            //
        }

        private void SwitchToTourLogs(object sender, RoutedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            var tourlogWindow = new TourlogWindow();
            tourlogWindow.DataContext = mainWindow.MainFrame.DataContext;
            mainWindow?.MainFrame.Navigate(tourlogWindow);
        }
    }
}
