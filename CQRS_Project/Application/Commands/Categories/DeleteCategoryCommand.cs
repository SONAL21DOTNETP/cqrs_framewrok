using MediatR;

namespace Application.Commands.Categories
{
    public class DeleteCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
