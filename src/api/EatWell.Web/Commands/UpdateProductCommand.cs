using MediatR;

namespace EatWell.API.Commands
{
    using DTO.Requests;
    using DTO.Responses;

    public class UpdateProductCommand : IRequest<UpdateProductResponse>
    {
        public int Id { get; }

        public UpdateProductRequest UpdateProductRequest { get; }

        public UpdateProductCommand(int id, UpdateProductRequest updateProductRequest)
        {
            UpdateProductRequest = updateProductRequest;
            Id = id;
        }
    }
}