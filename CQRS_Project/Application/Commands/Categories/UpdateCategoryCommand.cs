using MediatR;

namespace Application.Commands.Categories
{
    public class UpdateCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
    }
}
