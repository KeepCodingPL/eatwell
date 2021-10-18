namespace EatWell.API.Services
{
    using Models;
    public interface IProductService
    {
        void UpdateProduct(int idProduct,string productName,string productBrand);
    }
}
