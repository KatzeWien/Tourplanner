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

namespace NewVersionOfTourplanner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AllDataManagement AllDataManagement { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            AllDataManagement = new AllDataManagement();
            MainFrame.DataContext = AllDataManagement;
        }
    }
}
