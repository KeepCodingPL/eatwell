using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EatWell.API.Handlers
{
    using DTO.Responses;
    using Queries;
    using Services;

    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<GetProductResponse>>
    {
        private readonly IProductService _productService;

        public GetProductsHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IEnumerable<GetProductResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsAsync();
        }
    }
}