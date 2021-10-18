using Microsoft.AspNetCore.Mvc;


namespace EatWell.API.Controllers
{
    using Models;
    using Services;
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPut]
        public IActionResult UpdatePorduct(ProductModel product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }
    }
}
