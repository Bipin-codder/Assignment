using Application.DTOs.Category;
using Application.DTOs.Common;
using Application.DTOs.Product;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CategoryProductsDto : BaseDto
    {   
        public int CategoryId { get; set; }
        public virtual CategoryDtos Category { get; set; }        
        public int ProductId { get; set; }
        public virtual List<ProductDto> Products { get; set; }
    }
}
