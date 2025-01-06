using MediatR;
using Application.DTOs;

namespace Application.Queries.Categories
{
    public class DeleteCategoryQuery : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
