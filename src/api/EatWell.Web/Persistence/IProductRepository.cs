using System.Collections;
using System.Collections.Generic;

namespace EatWell.API.Persistence
{
    using Models;
    using System.Collections.Generic;

    public interface IProductRepository
    {

        void DeleteProduct(int id);
        void CreateProduct(ProductModel product);
        IEnumerable<ProductModel> GetProducts();


        void UpdateProduct(ProductModel product);

    }
}
