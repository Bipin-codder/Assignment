using Application.DTOs.Product;
using Application.Features.Products.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Handlers.Queries
{
    public class GetProductDetailRequestHandler : IRequestHandler<GetProductDetailRequest, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetProductDetailRequestHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public  async Task<ProductDto> Handle(GetProductDetailRequest request, CancellationToken cancellationToken)
        {
            var product =await _productRepository.GetProductWithDetails(request.id);
            return _mapper.Map<ProductDto>(product);    
        }
    }
}
