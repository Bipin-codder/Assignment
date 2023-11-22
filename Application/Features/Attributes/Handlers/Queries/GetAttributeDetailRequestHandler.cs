using Application.DTOs.Attribute;
using Application.Features.Attributes.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Attributes.Handlers.Queries
{
    public class GetAttributeDetailRequestHandler : IRequestHandler<GetAttributeDetailRequest, AttributeDto>
    {
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;

        public GetAttributeDetailRequestHandler(IAttributeRepository attributeRepository,IMapper mapper)
        {
            _attributeRepository = attributeRepository;
            _mapper = mapper;            
        }
        public async Task<AttributeDto> Handle(GetAttributeDetailRequest request, CancellationToken cancellationToken)
        {
            var attribute = await _attributeRepository.Get(request.id);
            return _mapper.Map<AttributeDto>(attribute);
        }
    }
}
