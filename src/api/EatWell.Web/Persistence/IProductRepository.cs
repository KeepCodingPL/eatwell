using System.Collections;
using System.Collections.Generic;

namespace EatWell.API.Persistence
{
    using EatWell.API.DTO.Requests;
    using Models;
    using System.Collections.Generic;

    public interface IProductRepository
    {

        void DeleteProduct(int id);
        void CreateProduct(CreateProductRequest product);
        IEnumerable<ProductModel> GetProducts();
        void UpdateProduct(UpdateProductRequest product);

    }
}
