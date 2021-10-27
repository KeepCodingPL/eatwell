namespace EatWell.API.Persistence
{
    using Models;
    public interface IProductRepository
    {
        void CreateProduct(ProductModel product);

        void UpdateProduct(ProductModel product);

    }
}
