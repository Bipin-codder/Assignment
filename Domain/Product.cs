using Domain.Common;

namespace Domain
{
    public class Product : BaseDomainEntity
    {   
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual List<ProductAttributes> ProductAttributes { get; set; }
        public virtual CategoryProducts Category { get; set; }
    }
}
