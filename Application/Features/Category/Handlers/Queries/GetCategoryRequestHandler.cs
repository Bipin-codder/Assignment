using Application.DTOs.Category;
using Application.DTOs.Product;
using Application.Features.Category.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Handlers.Queries
{
    public class GetCategoryRequestHandler : IRequestHandler<GetCategoryRequest, List<CategoryDtos>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryRequestHandler(ICategoryRepository categoryRepository,IMapper mapper)
        {
         _categoryRepository = categoryRepository;
         _mapper = mapper;
        }
        public async Task<List<CategoryDtos>> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
        {
            var products = await _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryDtos>>(products);
        }
    }
}
