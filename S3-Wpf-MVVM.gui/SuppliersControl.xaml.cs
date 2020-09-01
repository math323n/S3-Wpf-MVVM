﻿using S3_Wpf_MVVM.gui.ViewModels;
using System;
using System.Collections.Generic;
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

namespace S3_Wpf_MVVM.gui
{
    /// <summary>
    /// Interaction logic for SuppliersControl.xaml
    /// </summary>
    public partial class SuppliersControl: UserControl
    {

        SupplierViewModel suppliersViewModel;

        public SuppliersControl()
        {
            InitializeComponent();
            suppliersViewModel = this.DataContext as SupplierViewModel;

        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            suppliersViewModel.Initialize();
        }
    }

}