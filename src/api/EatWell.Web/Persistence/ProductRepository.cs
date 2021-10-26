using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EatWell.API.Persistence
{
    public class ProductRepository : IProductRepository
    {

        private readonly List<ProductRequest> _source;
        private readonly EatWellContext _eatWellContext;


        public ProductRepository(EatWellContext eatWellContext)
        {
            _eatWellContext = eatWellContext; 
        }

        public void DeleteProduct(int id)
        {
            var product = _eatWellContext.Products.Single(c => c.IdProduct == id);

            _eatWellContext.Products.Remove(product);
        }
        public void UpdateProduct(ProductRequest product)
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
