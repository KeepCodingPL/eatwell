using MediatR;

namespace EatWell.API.Commands
{
    using DTO.Requests;
    using DTO.Responses;

    public class CreateProductCommand : IRequest<CreateProductResponse>
    {
        public CreateProductRequest CreateProductRequest { get; }

        public CreateProductCommand(CreateProductRequest createProductRequest)
        {
            CreateProductRequest = createProductRequest;
        }
    }
}