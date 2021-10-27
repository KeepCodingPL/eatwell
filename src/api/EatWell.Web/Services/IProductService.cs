using System.Collections;
using System.Collections.Generic;

namespace EatWell.API.Services
{
    using Models;
    using System.Collections.Generic;

    public interface IProductService
    {

        void DeleteProduct(int id);

        void CreateProduct(ProductModel product);

        IEnumerable<ProductModel> GetProducts();
        
        void UpdateProduct(ProductModel product);
    }
}
