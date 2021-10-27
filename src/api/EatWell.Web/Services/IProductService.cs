namespace EatWell.API.Services
{
    using Models;
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        
        void UpdateProduct(ProductModel product);
    }
}
