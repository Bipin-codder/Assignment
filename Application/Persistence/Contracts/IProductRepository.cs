using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product> GetProductWithDetails(int id);
        Task<List<Product>> GetProductWithDetails();
    }
}
