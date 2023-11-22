using Application.Features.Attributes.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Attributes.Handlers.Commands
{
    public class UpdateAttributeCommandHandler : IRequestHandler<UpdateAttributeCommand, Unit>
    {
        private readonly IAttributeRepository _attributeRepository;
        private readonly IMapper _mapper;
        public UpdateAttributeCommandHandler(IAttributeRepository attributeRepository, IMapper mapper)
        {
            _attributeRepository = attributeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateAttributeCommand request, CancellationToken cancellationToken)
        {
            var attribute = await _attributeRepository.Get(request.AttributeDto.id);
            _mapper.Map(request.AttributeDto, attribute);
            await _attributeRepository.Update(attribute);
            return Unit.Value;
        }
    }
}
