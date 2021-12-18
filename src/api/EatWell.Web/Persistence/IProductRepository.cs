namespace EatWell.API.Persistence
{
    using DTO.Requests;
    using DTO.Responses;
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IEnumerable<GetProductResponse> GetProducts();

        GetProductResponse GetProduct(int id);

        void DeleteProduct(int id);

        CreateProductResponse CreateProduct(CreateProductRequest product);

        UpdateProductResponse UpdateProduct(int id, UpdateProductRequest product);
    }
}