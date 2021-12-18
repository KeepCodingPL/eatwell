using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EatWell.API.Handlers
{
    using Commands;
    using DTO.Responses;
    using Services;

    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        private readonly IProductService _productService;

        public CreateProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.CreateProductAsync(request.CreateProductRequest);
        }
    }
}