using Application.Persistence.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ConnectionDBContext _dbContext;
        public ProductRepository(ConnectionDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<Product> GetProductWithDetails(int id)
        {
            var Product = await _dbContext.Product.Include(q => q.Category).Include(x => x.ProductAttributes)
                            .FirstOrDefaultAsync(y => y.Id == id);

            return Product;
        }

        public async Task<List<Product>> GetProductWithDetails()
        {
            var Products = await _dbContext.Product.Include(q => q.Category)
                                .Include(x => x.ProductAttributes).ToListAsync();
            return Products;            
        }
    }
}
