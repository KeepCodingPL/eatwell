using Microsoft.AspNetCore.Mvc;


namespace EatWell.API.Controllers
{
    using Models;
    using Services;

    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpDelete]
        public IActionResult ConsistentProduct(int id)
        {
            _productService.ConsistentProduct(id);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePorduct(ProductRequest product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }
    }
}
