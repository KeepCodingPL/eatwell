using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatWell.API.Controllers
{
    using DTO.Requests;
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
        public IActionResult GetProducts() => Ok(_productService.GetProducts());

        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id) => Ok(_productService.GetProduct(id));

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateProduct(CreateProductRequest product)
        {
            var createdProduct = _productService.CreateProduct(product);

            return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdatePorduct(int id, UpdateProductRequest updateRequest) => Ok(_productService.UpdateProduct(id, updateRequest));

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);

            return NoContent();
        }
    }
}