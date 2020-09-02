using S3_Wpf_MVVM.DataAccess;
using S3_Wpf_MVVM.gui.ViewModels;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace S3_Wpf_MVVM.gui
{
    /// <summary>
    /// Interaction logic for ProductsControl.xaml
    /// </summary>
    public partial class ProductsControl: UserControl
    {
        #region Fields
        readonly ProductsViewModel productsViewModel;
        private bool isLoaded;
        #endregion

      

        #region Constructor
        public ProductsControl()
        {
            InitializeComponent();
            productsViewModel = DataContext as ProductsViewModel;
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
                productsViewModel.Initialize();
            }
            
        }






        #endregion

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}