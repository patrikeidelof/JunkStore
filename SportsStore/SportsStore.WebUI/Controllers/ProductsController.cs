namespace SportsStore.WebUI.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using SportsStore.Domain.Abstract;
    using SportsStore.Domain.Concrete;

    /// <summary>
    /// Controller for Products
    /// </summary>
    public class ProductsController : Controller
    {
        /// <summary>
        /// private link to repository
        /// </summary>
        private IProductsRepository productsRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        public ProductsController()
        {
            this.productsRepository = new FakeProductsRepository();
        }

        public ViewResult List()
        {
            return this.View(this.productsRepository.Products.ToList());
        }
    }
}
