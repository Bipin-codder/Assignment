using Application.DTOs;
using Application.DTOs.Attribute;
using Application.DTOs.Product;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Attribute,AttributeDto>().ReverseMap();
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Attribute, AttributeDto>().ReverseMap();
            CreateMap<ProductAttributes,ProductAttributeDto>().ReverseMap();
            CreateMap<CategoryProducts,CategoryProductsDto>().ReverseMap();             
        }
    }
}
