using System.Collections.Generic;
using EatWell.API.Models;

namespace EatWell.API.Services
{
    using Persistence;
    using Models;
    using System.Collections.Generic;
    using EatWell.API.DTO.Requests;

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) => _productRepository = productRepository;
        
        public void CreateProduct(ProductModel product) => _productRepository.CreateProduct(product);

        public void DeleteProduct(int id) => _productRepository.DeleteProduct(id);
        
        public IEnumerable<ProductModel> GetProducts() => _productRepository.GetProducts();
        
        public void UpdateProduct(UpdateRequestDto product) => _productRepository.UpdateProduct(product);
    }
}
