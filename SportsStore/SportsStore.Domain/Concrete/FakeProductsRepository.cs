namespace SportsStore.Domain.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using SportsStore.Domain.Abstract;
    using SportsStore.Domain.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FakeProductsRepository : IProductsRepository
    {
        /// <summary>
        /// Static in memory fake repository of products
        /// </summary>
        private static IQueryable<Product> fakeProducts =
            new List<Product>
                {
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Surf Board", Price = 179 },
                    new Product { Name = "Running shoes", Price = 95 }
                }.AsQueryable();

        /// <summary>
        /// Gets Products.
        /// </summary>
        public IQueryable<Product> Products
        {
            get
            {
                return fakeProducts;
            }
        }
    }
}
