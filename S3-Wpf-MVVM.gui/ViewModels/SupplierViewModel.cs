using S3_Wpf_MVVM.DataAccess;
using S3_Wpf_MVVM.Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace S3_Wpf_MVVM.gui.ViewModels
{
    public class SupplierViewModel: ViewModel
    {

        protected Supplier suppliers;
        protected Supplier selectedSupplier;
        #region Product constructor
        public SupplierViewModel()
        {
            Suppliers = new ObservableCollection<Supplier>();
        }
        #endregion

        #region Collections
        public ObservableCollection<Supplier> Suppliers { get; set; }
        public Supplier SelectedSupplier
        {
            get
            {
                return selectedSupplier;
            }

            set
            {
                selectedSupplier = value;
                OnPropertyChanged(nameof(selectedSupplier));
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Initializes all products
        /// </summary>
        public void Initialize()
        {
            LoadAllSuppliers();
        }

        /// <summary>
        /// Loads all products
        /// </summary>
        private void LoadAllSuppliers()
        {
            SupplierRepository supplierRepository = new SupplierRepository();
            IEnumerable<Supplier> suppliers = supplierRepository.GetAll();
            Suppliers.ReplaceWith(suppliers);
        }
        #endregion
    }
}