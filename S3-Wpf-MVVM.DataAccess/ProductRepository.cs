﻿using Microsoft.EntityFrameworkCore;

using S3_Wpf_MVVM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S3_Wpf_MVVM.DataAccess
{
    public class ProductRepository: RepositoryBase<Product>
    {
        protected const string supplier = "Supplier";

        public override Product GetBy(int id)
        {
            return context.Products
                .Include(supplier)
                .SingleOrDefault(p => p.ProductID == id);
        }

        /// <summary>
        /// Gets all products & the associated supplier
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Product> GetAll()
        {
            return context.Products.Include(supplier);
        }
        /// <summary>
        /// Deletes selected product
        /// </summary>
        /// <param name="t"></param>
        public override void Delete(Product t)
        {
            base.Delete(t);
        }

        /// <summary>
        /// Adds a product
        /// </summary>
        /// <param name="t"></param>
        public override void Add(Product t)
        {
            base.Add(t);
        }
    }
}
