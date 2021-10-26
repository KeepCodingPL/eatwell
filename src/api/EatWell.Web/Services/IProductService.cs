namespace EatWell.API.Services
{
    using Models;
    using System.Collections.Generic;

    public interface IProductService
    {
        void ConsistentProduct(int id);

        void UpdateProduct(ProductRequest product);
    }
}
