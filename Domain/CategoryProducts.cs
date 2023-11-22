using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CategoryProducts : BaseDomainEntity
    {   

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; } = Guid.Empty;
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; } = Guid.Empty;
        public virtual List<Product> Products { get; set; }
    }
}
