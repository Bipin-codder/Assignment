using Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Requests.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public ProductDto ProductDto { get; set; }
    }
}
