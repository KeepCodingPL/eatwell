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

        [HttpPost]
        public IActionResult CreateProduct(ProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPut]
        public IActionResult UpdatePorduct(ProductModel product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }
    }
}
