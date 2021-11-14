using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EatWell.API.DTO.Requests;

namespace EatWell.API.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly EatWellContext _eatWellContext;

        public ProductRepository(EatWellContext eatWellContext)
        {
            _eatWellContext = eatWellContext;
        }
        public void CreateProduct(ProductModel product)
        {
            _eatWellContext.Products.Add(new ProductModel()
            {
                IdProduct = product.IdProduct,
                Name = product.Name,
                Brand = product.Brand,
                Ingredients = product.Ingredients,
                IsHalal = product.IsHalal,
                IsVegan = product.IsVegan,
                IsVegeterian = product.IsVegeterian
            });
            _eatWellContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _eatWellContext.Products.FirstOrDefault(p => p.IdProduct == id);
            _eatWellContext.Entry(product).State = EntityState.Deleted;
            _eatWellContext.SaveChanges();
        }
        
        public IEnumerable<ProductModel> GetProducts()
        {
           return _eatWellContext.Products.ToList();
        }


        public void UpdateProduct(UpdateRequest updateRequest)
        {
            var productInList = _eatWellContext.Products.FirstOrDefault(p => p.IdProduct == updateRequest.IdProduct);
            
            if (productInList is null)
            {
                throw new Exception("Product not defined");
            }
            
            productInList.IsVegeterian = updateRequest.IsVegeterian;
            productInList.IsVegan = updateRequest.IsVegan;
            productInList.IsHalal = updateRequest.IsHalal;

            _eatWellContext.SaveChanges();
        }
    }
}
