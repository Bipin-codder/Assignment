using Application.Features.Attributes.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.Attributes.Handlers.Commands
{
    public class DeleteAttributeCommandHandler : IRequestHandler<DeleteAttributeCommand>
    {
        private readonly IAttributeRepository _attributeRepository;        
        public DeleteAttributeCommandHandler(IAttributeRepository attributeRepository)
        {
            _attributeRepository = attributeRepository;            
        }
        public async Task<Unit> Handle(DeleteAttributeCommand request, CancellationToken cancellationToken)
        {
            var attribute = await _attributeRepository.Get(request.id);
            await _attributeRepository.Delete(attribute);
            return Unit.Value;
        }
    }
}
