﻿using EatWell.API.Models;

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
        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public void UpdateProduct(ProductModel product)
        {

            _productRepository.UpdateProduct(product);

        }
    }
}
