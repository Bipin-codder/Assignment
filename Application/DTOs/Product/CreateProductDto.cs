using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Product
{
    public class CreateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual List<ProductAttributeDto> ProductAttributes { get; set; }
        public virtual CategoryProductsDto Category { get; set; }
    }
}
