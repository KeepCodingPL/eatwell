using System.Collections;
using System.Collections.Generic;

namespace EatWell.API.Services
{
    using Models;
    public interface IProductService
    {
        void CreateProduct(ProductModel product);

        IEnumerable<ProductModel> GetProducts();
        
        void UpdateProduct(ProductModel product);
    }
}
