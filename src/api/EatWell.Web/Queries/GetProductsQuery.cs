using MediatR;
using System.Collections.Generic;

namespace EatWell.API.Queries
{
    using DTO.Responses;

    public class GetProductsQuery : IRequest<IEnumerable<GetProductResponse>>
    { 
    }
}