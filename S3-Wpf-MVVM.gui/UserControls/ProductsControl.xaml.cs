using S3_Wpf_MVVM.gui.ViewModels;

using System.Windows;
using System.Windows.Controls;

namespace S3_Wpf_MVVM.gui
{
    /// <summary>
    /// Interaction logic for ProductsControl.xaml
    /// </summary>
    public partial class ProductsControl: UserControl
    {
        ProductsViewModel productsViewModel;

        public ProductsControl()
        {
            InitializeComponent();
            productsViewModel = this.DataContext as ProductsViewModel;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            productsViewModel.Initialize();
        }
    }
}