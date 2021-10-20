using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EatWell.API.Persistence
{
    public class ProductRepository : IProductRepository
    {

        private readonly List<ProductModel> _source;
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
    }
}
