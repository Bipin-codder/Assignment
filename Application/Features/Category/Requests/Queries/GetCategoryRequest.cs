using Application.DTOs.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Requests.Queries
{
    public class GetCategoryRequest : IRequest<List<CategoryDtos>>
    {

    }
}
