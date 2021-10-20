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
        public void SellProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
