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

        

        public void UpdateProduct(int idProduct, string productName, string productBrand)
        {
            ProductModel product = Products.Find(idProduct,productName,productBrand);

           
            var productDb = new ProductModel
            {
                IdProduct = product.IdProduct,
                Name = product.Name,
                Brand = product.Brand,
                Ingredients = product.Ingredients,
                IsVegeterian = product.IsVegeterian,
                IsVegan = product.IsVegan,
                IsHalal = product.IsHalal
            };

            _productPersistenceService.UpdateProduct(productDb);

        }
    }
}
