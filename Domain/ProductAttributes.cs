using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductAttributes : BaseDomainEntity
    {   
        public int ProductId { get; set; }                

        [ForeignKey(nameof(Attribute))]
        public int AttributeId { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
}
