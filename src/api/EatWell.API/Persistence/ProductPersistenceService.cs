using EatWell.API.Models;

namespace EatWell.API.Persistence
{
    public class ProductPersistenceService : IProductPersistenceService
    {
        private readonly EatWellContext _eatWellContext;

        public ProductPersistenceService(EatWellContext eatWellContext)
        {
            _eatWellContext = eatWellContext;
        }

        public void UpdateProduct(ProductModel product)
        {
            _eatWellContext.Products.Update(product);
        }
    }
}
