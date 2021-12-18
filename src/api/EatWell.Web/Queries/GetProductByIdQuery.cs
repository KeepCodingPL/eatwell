using MediatR;

namespace EatWell.API.Queries
{
    using DTO.Responses;

    public class GetProductByIdQuery : IRequest<GetProductResponse>
    {
        public int Id { get;  }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}