using MediatR;
using Application.DTOs;


namespace Application.Queries.Categories
{
    public class GetCategoryByIdQuery : IRequest<CategoryDto>
    {
        public int Id { get; set; }
    }

}
