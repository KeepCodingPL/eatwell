using EatWell.API.Models;

namespace EatWell.API.Services
{
    using Persistence;
    using Models;
    public class ProductService : IProductService
    {
        private readonly IProductPersistenceService _productPersistenceService;

        public ProductService(IProductPersistenceService productPersistenceService)
        {
            _productPersistenceService = productPersistenceService;
        }

        public void UpdateProduct(ProductModel product)
        {
            var product = new ProductModel { };
            _productPersistenceService.UpdateProduct();
        }
    }
}
