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

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePorduct(ProductModel product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }
    }
}
