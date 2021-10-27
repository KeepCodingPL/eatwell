namespace EatWell.API.Services
{
    using Models;
    using System.Collections.Generic;

    public interface IProductService
    {
        void DeleteProduct(int id);

        void UpdateProduct(ProductModel product);
    }
}
