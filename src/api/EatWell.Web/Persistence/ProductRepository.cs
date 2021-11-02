using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var product = _eatWellContext.Products.First(p => p.IdProduct == id);
            _eatWellContext.Entry(product).State = EntityState.Deleted;
            _eatWellContext.SaveChanges();
        }
        
        public IEnumerable<ProductModel> GetProducts()
        {
           return _eatWellContext.Products.ToList();
        }


        public void UpdateProduct(ProductModel product)
        {
            var productInList = _eatWellContext.Products.First(p => p.IdProduct == product.IdProduct);
            
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
