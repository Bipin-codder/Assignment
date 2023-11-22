using Application.DTOs.Attribute;
using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProductAttributeDto : BaseDto
    {
        public int ProductId { get; set; }        
        public int AttributeId { get; set; }
        public virtual AttributeDto Attribute { get; set; }
    }

}
