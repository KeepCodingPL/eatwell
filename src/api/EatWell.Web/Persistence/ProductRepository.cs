using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Persistence
{
    using DTO.Requests;
    using DTO.Responses;
    using Utils;
    using Models;

    public class ProductRepository : IProductRepository
    {
        private readonly EatWellContext _eatWellContext;

        public ProductRepository(EatWellContext eatWellContext)
        {
            _eatWellContext = eatWellContext;
        }

        public async Task<IEnumerable<GetProductResponse>> GetProductsAsync() => await _eatWellContext.Products.Select(p => new GetProductResponse(p)).ToListAsync();

        public async Task<GetProductResponse> GetProductByIdAsync(int id)
        {
            var product = await _eatWellContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            return product is null ? null : new(product);
        }

        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest product)
        {
            var prodcutToAdd = new ProductModel()
            {
                Name = product.Name,
                Brand = product.Brand,
                Ingredients = IngredientsHelper.IngredientsToString(product.Ingredients),
                IsHalal = product.IsHalal,
                IsVegan = product.IsVegan,
                IsVegeterian = product.IsVegeterian
            };

            _eatWellContext.Entry(prodcutToAdd).State = EntityState.Added;

            await _eatWellContext.SaveChangesAsync();

            return new CreateProductResponse(prodcutToAdd);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _eatWellContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            _eatWellContext.Entry(product).State = EntityState.Deleted;

            await _eatWellContext.SaveChangesAsync();
        }

        public async Task<UpdateProductResponse> UpdateProductAsync(int id, UpdateProductRequest updateRequest)
        {
            var productInList = await _eatWellContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (productInList is null)
            {
                throw new Exception("Product not defined");
            }

            productInList.IsVegeterian = updateRequest.IsVegeterian;
            productInList.IsVegan = updateRequest.IsVegan;
            productInList.IsHalal = updateRequest.IsHalal;

            _eatWellContext.Entry(productInList).State = EntityState.Modified;

            await _eatWellContext.SaveChangesAsync();

            return new UpdateProductResponse(productInList);
        }
    }
}