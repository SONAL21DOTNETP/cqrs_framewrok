using MediatR;
using System.Collections.Generic;
using Application.DTOs;

namespace Application.Queries.Categories
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryDto>>
    {
    }
}
