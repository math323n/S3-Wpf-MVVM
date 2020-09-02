using S3_Wpf_MVVM.DataAccess;
using S3_Wpf_MVVM.Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace S3_Wpf_MVVM.gui.ViewModels
{
    public class ProductsViewModel: ViewModel, INotifyPropertyChanged
    {
        #region Fields
        // Selected product
        private Product newProduct = new Product();
        private Product selectedProduct;
        #endregion

        public ICommand DeleteCommand
        {
            get;
        }
        public ICommand NewCommand
        {
            get;
        }
        public ICommand SaveCommand
        {
            get;
        }
        public ICommand GetByCommand
        {
            get;
        }
        public ICommand GetAllCommand
        {
            get;
        }

        #region Product constructor
        public ProductsViewModel()
        {
          
            Products = new ObservableCollection<Product>();
            DeleteCommand = new RelayCommand(DeleteProduct);
            NewCommand = new RelayCommand(AddProduct);

        }
        #endregion

        #region Collections
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
        #endregion

        #region Methods

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

        private void DeleteProduct()
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.Delete(SelectedProduct);
        
        }
        private void AddProduct(Product newProduct)
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.Add(newProduct);
            
        }
        #endregion
    }
}