namespace EatWell.API.Services
{
    using DTO.Requests;
    using DTO.Responses;
    using System.Collections.Generic;

    public interface IProductService
    {
        IEnumerable<GetProductResponse> GetProducts();

        GetProductResponse GetProduct(int id);

        void DeleteProduct(int id);

        CreateProductResponse CreateProduct(CreateProductRequest product);

        UpdateProductResponse UpdateProduct(int id, UpdateProductRequest product);
    }
}