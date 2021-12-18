using MediatR;

namespace EatWell.API.Commands
{
    public class DeleteProductCommand : IRequest
    {
        public int Id { get; }

        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}