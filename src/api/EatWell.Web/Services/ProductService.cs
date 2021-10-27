﻿using EatWell.API.Models;

namespace EatWell.API.Services
{
    using Persistence;
    using Models;
    
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(ProductModel product)
        {

            _productRepository.CreateProduct(product);

        }

        public void UpdateProduct(ProductModel product)
        {

            _productRepository.UpdateProduct(product);
 
        }
    }
}