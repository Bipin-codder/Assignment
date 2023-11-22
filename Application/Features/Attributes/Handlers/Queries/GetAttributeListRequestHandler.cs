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
    public class GetAttributeListRequestHandler : IRequestHandler<GetAttributeListRequest, List<AttributeDto>>
    {
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;

        public GetAttributeListRequestHandler(IAttributeRepository attributeRepository,IMapper mapper)
        {
            _attributeRepository = attributeRepository;
            _mapper = mapper;

        }
        public async Task<List<AttributeDto>> Handle(GetAttributeListRequest request, CancellationToken cancellationToken)
        {
            var attributes = await _attributeRepository.GetAll();
            return _mapper.Map<List<AttributeDto>>(attributes);            
        }
    }
}
