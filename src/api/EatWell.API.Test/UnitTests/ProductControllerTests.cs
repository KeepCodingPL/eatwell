using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EatWell.API.Controllers;
using EatWell.API.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;


namespace EatWell.API.Test.UnitTests
{
    using Models;
    using Persistence;
    public class ProductControllerTests
    {
        private readonly Mock<IProductService> _mockProductService;
        private readonly ProductController _testing;

        public ProductControllerTests()
        {
           _mockProductService = new Mock<IProductService>();
           _testing = new ProductController(_mockProductService.Object);
        }

        [Fact]
        public void CreateProduct_ShouldReturnOk()
        {
            var expected = new ProductModel()
            {
                Name = "Product",
                Brand = "German",
                Ingredients = {},
                IsHalal = true,
                IsVegan = false,
                IsVegeterian = false
            };

            var actual = _testing.CreateProduct(expected);

            Assert.IsType<OkResult>(actual);
        }

        [Fact]
        public void ShouldCheck_WhenGetProducts_IsEmpty()
        {
            _mockProductService.Setup(product => product.GetProducts());

            var actual = (OkObjectResult) _testing.GetProducts();

            Assert.Empty( (IEnumerable<ProductModel>) actual.Value);
        }
       
    }
}