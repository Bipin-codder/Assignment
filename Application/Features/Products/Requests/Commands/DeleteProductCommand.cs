using Application.DTOs.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Requests.Commands
{
    public class DeleteProductCommand : IRequest
    {
        public int id { get; set; }
    }
}
