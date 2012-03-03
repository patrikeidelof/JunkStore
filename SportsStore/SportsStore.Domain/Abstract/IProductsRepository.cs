namespace SportsStore.Domain.Abstract
{
    using System.Linq;

    using SportsStore.Domain.Entities;

    /// <summary>
    /// Interface for a products repository.
    /// </summary>
    public interface IProductsRepository
    {
        /// <summary>
        /// Gets Products.
        /// </summary>
        IQueryable<Product> Products { get; }
    }
}