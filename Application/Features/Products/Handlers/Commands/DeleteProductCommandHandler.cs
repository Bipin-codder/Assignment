﻿using Application.Features.Products.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Handlers.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public DeleteProductCommandHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.Get(request.id);            
            await _productRepository.Delete(product);
            return Unit.Value;
        }
    }
}
