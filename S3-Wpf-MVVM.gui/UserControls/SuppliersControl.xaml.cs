using S3_Wpf_MVVM.gui.ViewModels;

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
        #region Fields
        readonly SupplierViewModel suppliersViewModel;
        private bool isLoaded;
        #endregion

        #region Constructor
        public SuppliersControl()
        {
            InitializeComponent();
            suppliersViewModel = DataContext as SupplierViewModel;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Is run when UserControl is loaded once
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if(!isLoaded)
            {
                isLoaded = true;
                suppliersViewModel.Initialize();

            }
        }
        #endregion
    }
}