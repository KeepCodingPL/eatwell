﻿using EatWell.API.Models;
using System;
using System.Collections.Generic;

namespace EatWell.API.Persistence
{
    public class ProductRepository : IProductRepository
    {

        private readonly List<ProductModel> _source;


        public ProductRepository()
        {

            _source = new List<ProductModel>();
        }
        public void CreateProduct(ProductModel product)
        {
            _source.Add(product);
        }


        public void UpdateProduct(ProductModel product)
        {

            var productInList = _source.Find(p => p.IdProduct == product.IdProduct);
            if (productInList is null)
            {
                throw new Exception("product not defined");
            }
            productInList.Name = product.Name;
            productInList.Brand = product.Brand;
            productInList.Ingredients = product.Ingredients;
            productInList.IsVegeterian = product.IsVegeterian;
            productInList.IsVegan = product.IsVegan;
            productInList.IsHalal = product.IsHalal;
        }
    }
}