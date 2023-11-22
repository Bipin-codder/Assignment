using Application.DTOs.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Requests.Commands
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public CategoryDtos CategoryDtos { get; set; }
    }
}
