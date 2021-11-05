using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using EatWell.API.Services;
using Moq;
using EatWell.API.Controllers;
using EatWell.API.Models;
using LetsDoIt.Moody.Application.CustomExceptions;

namespace EatWell.API.Test.Controllers
{
    public class ProductControllerTest
    {
        private readonly Mock<IProductService> _mockCategoryService;
        private readonly  ProductController _testing;

        public ProductControllerTest()
        {
            _mockCategoryService = new Mock<IProductService>();
            _testing = new ProductController(_mockCategoryService.Object);
        }

        [Fact]
        public void DeleteProduct_IdExists_ShoulReturnOk()
        {
            var id = 3;

            _mockCategoryService
                .Setup(service =>
                    service.DeleteProduct(
                                It.IsAny<int>()));

            var actual =  _testing.DeleteProduct(id);
            Assert.IsType<OkResult>(actual);

        }
    }
}
