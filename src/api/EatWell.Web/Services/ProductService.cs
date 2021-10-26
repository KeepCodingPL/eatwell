using EatWell.API.Models;

namespace EatWell.API.Services
{
    using Persistence;
    using Models;
    using System.Collections.Generic;

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void ConsistentProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public void UpdateProduct(ProductRequest product)
        {

            _productRepository.UpdateProduct(product);

        }
    }
}
