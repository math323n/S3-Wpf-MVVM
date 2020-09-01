using S3_Wpf_MVVM.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Wpf_MVVM.DataAccess
{

    public class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        #region Fields
        // Static Northwind context
        protected static NorthwindContext context;
        #endregion

        #region Constructor
        static RepositoryBase()
        {
            context = new NorthwindContext();
        }

        protected RepositoryBase() { }
        #endregion

        #region Methods
        /// <summary>
        /// Adds item & saves context
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes item & saves context
        /// </summary>
        /// <param name="t"></param>
        public void Delete(T t)
        {
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        /// <summary>
        /// Gets item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetBy(int id)
        {
            return context.Set<T>().Find(id);
        }

        /// <summary>
        /// Saves context
        /// </summary>
        /// <param name="t"></param>
        public void Update(T t)
        {
            context.SaveChanges();
        }
        #endregion
    }

}
