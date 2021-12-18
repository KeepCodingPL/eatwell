using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EatWell.API.Handlers
{
    using DTO.Responses;
    using Queries;
    using Services;

    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductResponse>
    {
        private readonly IProductService _productService;

        public GetProductByIdHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GetProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
           return await _productService.GetProductByIdAsync(request.Id);
        }
    }
}