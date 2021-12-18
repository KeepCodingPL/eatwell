using System.Collections.Generic;
using System.Threading.Tasks;

namespace EatWell.API.Persistence
{
    using DTO.Requests;
    using DTO.Responses;

    public interface IProductRepository
    {
        Task<IEnumerable<GetProductResponse>> GetProductsAsync();

        Task<GetProductResponse> GetProductByIdAsync(int id);

        Task DeleteProductAsync(int id);

        Task<CreateProductResponse> CreateProductAsync(CreateProductRequest product);

        Task<UpdateProductResponse> UpdateProductAsync(int id, UpdateProductRequest product);
    }
}