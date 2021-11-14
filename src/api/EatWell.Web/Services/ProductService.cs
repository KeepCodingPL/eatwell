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

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public void CreateProduct(CreateRequest product)
        {

            _productRepository.CreateProduct(product);

        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

       

        public void UpdateProduct(UpdateRequest product)
        {

            _productRepository.UpdateProduct(product);

        }
    }
}
