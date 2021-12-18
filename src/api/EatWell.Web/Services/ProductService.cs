namespace EatWell.API.Services
{
    using Persistence;
    using Models;
    using System.Collections.Generic;
    using DTO.Requests;
    using EatWell.API.DTO.Responses;

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productRepository) => _productRepository = productRepository;

        public IEnumerable<GetProductResponse> GetProducts() => _productRepository.GetProducts();

        public GetProductResponse GetProduct(int id) => _productRepository.GetProduct(id);

        public CreateProductResponse CreateProduct(CreateProductRequest product) => _productRepository.CreateProduct(product);

        public void DeleteProduct(int id) => _productRepository.DeleteProduct(id);
        
        
        public UpdateProductResponse UpdateProduct(UpdateProductRequest product) => _productRepository.UpdateProduct(product);
    }
}