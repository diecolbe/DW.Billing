using DW.Billing.ORM.BillingRepository.Interfaces;
using DW.Billing.ORM.BillingRepository.Repository;
using DW.Billing.ORM.Repository;
using DW.Billing.ORM.UnitOfWork;
using DW.Billing.Services.Interfaces;
using DW.Billing.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DW.Billing.Handlers
{
    public static class DependencyInyectionHandler
    {
        public static void DependencyInyectionConfig(this IServiceCollection services)
        {
            // Repository await UnitofWork
            services.AddScoped<UnitOfWork, UnitOfWork>();

            // Infrastructure
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            //Services
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IInvoiceService, InvoiceService>();

            //Repositories
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
