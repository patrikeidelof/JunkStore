namespace SportsStore.Domain.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using SportsStore.Domain.Abstract;
    using SportsStore.Domain.Entities;
using System.Data.Linq;

    /// <summary>
    /// This is a repository class for Products
    /// </summary>
    public class SqlProductsRepository : IProductsRepository
    {
        /// <summary>
        /// private handle to table
        /// </summary>
        private Table<Product> productsTable;

        public SqlProductsRepository(string connectionString)
        {
            this.productsTable = (new DataContext(connectionString)).GetTable<Product>();
        }

        public IQueryable<Product> Products
        {
            get
            {
                return this.productsTable;
            }
        }
    }
}
