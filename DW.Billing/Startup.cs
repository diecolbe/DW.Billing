using DW.Billing.Common;
using DW.Billing.Handlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace DW.Billing
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private ConnectionStrings _billingConnection { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            var billingConnection = new ConnectionStrings();
            Configuration.GetSection("ConnectionStrings").Bind(billingConnection);
            _billingConnection = billingConnection;

            services.Configure<ConnectionStrings>(options =>
            {
                options.ConnectionStringSQLServer = _billingConnection.ConnectionStringSQLServer;

            });
            services.AddSingleton(serviceProvider =>
                    serviceProvider.GetRequiredService<IOptions<ConnectionStrings>>().Value);

            services.AddDbContext<DW.Billing.ORM.Context.BillingContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("ConnectionStringSQLServer"),
               providerOptions => providerOptions.EnableRetryOnFailure()));

            services.DependencyInyectionConfig();
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
