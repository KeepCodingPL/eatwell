namespace EatWell.API.Persistence
{
    using Models;
    using System.Collections.Generic;

    public interface IProductRepository
    {
        void DeleteProduct(int id);

        void UpdateProduct(ProductRequest product);

    }
}
