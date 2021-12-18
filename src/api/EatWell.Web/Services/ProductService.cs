using System.Threading.Tasks;
using System.Collections.Generic;

namespace EatWell.API.Services
{
    using Persistence;
    using DTO.Requests;
    using DTO.Responses;

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productRepository) => _productRepository = productRepository;

        public async Task<IEnumerable<GetProductResponse>> GetProductsAsync() => await _productRepository.GetProductsAsync();

        public async Task<GetProductResponse> GetProductByIdAsync(int id) => await _productRepository.GetProductByIdAsync(id);

        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest product) => await _productRepository.CreateProductAsync(product);

        public async Task DeleteProductAsync(int id) => await _productRepository.DeleteProductAsync(id);
        
        public async Task<UpdateProductResponse> UpdateProductAsync(int id, UpdateProductRequest product) => await _productRepository.UpdateProductAsync(id, product);
    }
}