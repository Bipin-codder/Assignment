using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Attributes.Requests.Commands
{
    public class DeleteAttributeCommand : IRequest
    {
        public int id { get; set; }
    }
}
