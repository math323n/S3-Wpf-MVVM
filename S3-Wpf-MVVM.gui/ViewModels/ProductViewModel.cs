using S3_Wpf_MVVM.DataAccess;
using S3_Wpf_MVVM.Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace S3_Wpf_MVVM.gui.ViewModels
{
    public class ProductsViewModel: INotifyPropertyChanged
    {
        #region Fields
        // Event for property changed
        public event PropertyChangedEventHandler PropertyChanged;
        // Selected product
        private Product selectedProduct;
        #endregion

        #region Product constructor
        public ProductsViewModel()
        {
            Products = new ObservableCollection<Product>();
        }
        #endregion


        public ObservableCollection<Product> Products { get; set; }
        public Product SelectedProduct
        {
            get
            {
                return selectedProduct;
            }

            set
            {
                selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }


        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Initializes all products
        /// </summary>
        public void Initialize()
        {
            LoadAllProducts();
        }

        /// <summary>
        /// Loads all products
        /// </summary>
        private void LoadAllProducts()
        {
            ProductRepository productRepository = new ProductRepository();
            IEnumerable<Product> products = productRepository.GetAll();
            Products.ReplaceWith(products);
        }
        #endregion
    }
}