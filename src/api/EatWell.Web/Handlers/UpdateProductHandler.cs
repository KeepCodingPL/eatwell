using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EatWell.API.Handlers
{
    using Commands;
    using DTO.Responses;
    using Services;

    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResponse>
    {
        private readonly IProductService _productService;

        public UpdateProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<UpdateProductResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.UpdateProductAsync(request.Id, request.UpdateProductRequest);
        }
    }
}