using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EatWell.API.Controllers
{
    using DTO.Requests;
    using DTO.Responses;
    using Commands;
    using Queries;
    using Services;

    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly IMediator _mediator;

        public ProductController(IMediator mediator, IProductService productService)
        {
            _mediator = mediator;
            _productService = productService;
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetProductResponse>))]
        public async Task<IActionResult> GetProducts()
        {
            var query = new GetProductsQuery();

            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id:int}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(GetProductResponse))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProductById(int id)
        {
            var query = new GetProductByIdQuery(id);

            var result = await _mediator.Send(query);

            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, Type = typeof(CreateProductResponse))]
        public async Task<IActionResult> CreateProduct(CreateProductRequest createProductRequest)
        {
            var command = new CreateProductCommand(createProductRequest);

            var createdProduct = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id:int}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(UpdateProductResponse))]
        public async Task<IActionResult> UpdatePorduct(int id, UpdateProductRequest updateRequest)
        {
            var command = new UpdateProductCommand(id, updateRequest);

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id:int}")]
        [SwaggerResponse(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}