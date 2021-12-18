using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EatWell.API.Persistence
{
    using DTO.Requests;
    using DTO.Responses;
    using Models;

    public class ProductRepository : IProductRepository
    {
        private readonly EatWellContext _eatWellContext;

        public ProductRepository(EatWellContext eatWellContext)
        {
            _eatWellContext = eatWellContext;
        }

        public IEnumerable<GetProductResponse> GetProducts() => _eatWellContext.Products.Select(p => new GetProductResponse(p));

        public GetProductResponse GetProduct(int id) => new(_eatWellContext.Products.FirstOrDefault(p => p.Id == id));

        public CreateProductResponse CreateProduct(CreateProductRequest product)
        {
            var prodcutToAdd = new ProductModel()
            {
                Name = product.Name,
                Brand = product.Brand,
                Ingredients = product.Ingredients,
                IsHalal = product.IsHalal,
                IsVegan = product.IsVegan,
                IsVegeterian = product.IsVegeterian
            };

            _eatWellContext.Entry(prodcutToAdd).State = EntityState.Added;

            _eatWellContext.SaveChanges();

            return new CreateProductResponse(prodcutToAdd);
        }

        public void DeleteProduct(int id)
        {
            var product = _eatWellContext.Products.FirstOrDefault(p => p.Id == id);

            _eatWellContext.Entry(product).State = EntityState.Deleted;

            _eatWellContext.SaveChanges();
        }
        
        public UpdateProductResponse UpdateProduct(UpdateProductRequest updateRequest)
        {
            var productInList = _eatWellContext.Products.FirstOrDefault(p => p.Id == updateRequest.Id);
            
            if (productInList is null)
            {
                throw new Exception("Product not defined");
            }
            
            productInList.IsVegeterian = updateRequest.IsVegeterian;
            productInList.IsVegan = updateRequest.IsVegan;
            productInList.IsHalal = updateRequest.IsHalal;

            _eatWellContext.Entry(productInList).State = EntityState.Modified;

            _eatWellContext.SaveChanges();

            return new UpdateProductResponse(productInList);
        }
    }
}