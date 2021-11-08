using Microsoft.AspNetCore.Mvc;


namespace EatWell.API.Controllers
{
    using EatWell.API.DTO.Requests;
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

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpPut("{idProduct}")]
        public IActionResult UpdatePorduct(UpdateRequestDto updateRequest)
        {
            _productService.UpdateProduct(updateRequest);
                        
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);

            return Ok();
        }
    }
}
