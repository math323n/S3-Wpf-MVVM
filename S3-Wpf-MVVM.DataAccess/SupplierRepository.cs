using S3_Wpf_MVVM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Wpf_MVVM.DataAccess
{
    public class SupplierRepository: RepositoryBase<Supplier>
    {
        /// <summary>
        /// Gets all Supppliers
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Supplier> GetAll()
        {
            return context.Suppliers;
        }


      /*  public override Supplier GetBy(int id)
        {
            return 
        }*/
    }
}