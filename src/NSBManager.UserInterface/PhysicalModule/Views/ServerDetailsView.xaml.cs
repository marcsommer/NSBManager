﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NSBManager.UserInterface.PhysicalModule.Views
{
    /// <summary>
    /// Interaction logic for ServerDetailsView.xaml
    /// </summary>
    public partial class ServerDetailsView : IServerDetailsView
    {
        public ServerDetailsView()
        {
            InitializeComponent();
        }

        public IServerDetailsPresentationModel Model
        {
            get { return DataContext as IServerDetailsPresentationModel; }
            set { DataContext = value; }
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            var border = sender as Border;
            border.BorderBrush = Brushes.White;
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            var border = sender as Border;
            border.BorderBrush = Brushes.DimGray;
        }
    }
}
