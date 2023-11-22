using Application.Features.Attributes.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Application.DTOs.Attribute.Validate;

namespace Application.Features.Attributes.Handlers.Commands
{
    public class CreateAttributeCommandHandler : IRequestHandler<CreateAttributeCommand, int>
    {
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;

        public CreateAttributeCommandHandler(IAttributeRepository attributeRepository,IMapper mapper)
        {
            _attributeRepository = attributeRepository;
            _mapper = mapper;            
        }
        public async Task<int> Handle(CreateAttributeCommand request, CancellationToken cancellationToken)
        {

            var attribute = _mapper.Map<Domain.Attributes>(request.Attribute);
            attribute = await _attributeRepository.Add(attribute);
            return attribute.Id;
        }
    }
}
