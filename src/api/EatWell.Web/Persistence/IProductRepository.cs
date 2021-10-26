using System.Collections;
using System.Collections.Generic;

namespace EatWell.API.Persistence
{
    using Models;
    public interface IProductRepository
    {
        void CreateProduct(ProductModel product);
        IEnumerable<ProductModel> GetProducts();

        void UpdateProduct(ProductModel product);

    }
}
