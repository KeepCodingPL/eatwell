using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EatWell.API.Handlers
{
    using Commands;
    using Services;

    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand>
    {

        private readonly IProductService _productService;

        public DeleteProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.DeleteProductAsync(request.Id);

            return Unit.Value;
        }
    }
}