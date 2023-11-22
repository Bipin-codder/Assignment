using Application.DTOs.Attribute;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Attributes.Requests.Queries
{
    public class GetAttributeListRequest : IRequest<List<AttributeDto>>
    {
    }
}
