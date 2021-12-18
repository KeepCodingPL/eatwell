using Microsoft.AspNetCore.Mvc;

namespace EatWell.API.Controllers
{
    using EatWell.API.DTO.Requests;
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

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProduct(id);

            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductRequest product)
        {
            var createdProduct = _productService.CreateProduct(product);

            return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdatePorduct(UpdateProductRequest updateRequest)
        {
            return Ok(_productService.UpdateProduct(updateRequest));
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);

            return Ok();
        }
    }
}