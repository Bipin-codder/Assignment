using Application.Persistence.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ConnectionDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddScoped<IProductRepository, ProductRepository>();
            //service.AddScoped<IAttributeRepository, >();
            //service.AddScoped<ICategoryRepository, >();

            return service;
            
        }
    }
}
