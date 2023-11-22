using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Attribute
{
    public class UpdateAttributeDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public List<string> Values { get; set; } = new List<string>();
    }
}
