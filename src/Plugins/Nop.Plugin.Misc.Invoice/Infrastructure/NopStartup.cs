using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Data;
using Nop.Plugin.Misc.Invoice.Domain;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface;
using Nop.Plugin.Misc.Invoice.Services;

namespace Nop.Plugin.Misc.Invoice.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring services on application startup
    /// </summary>
    public class NopStartup : INopStartup
    {

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = DataSettingsManager.LoadSettings().ConnectionString;
            services.AddDbContext<Nop_dbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Models.MappingProfile());

            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IInvoiceSellService, InvoiceSellService>();
            services.AddScoped<IInvoiceSellUnitService, InvoiceSellUnitService>();

        }

        public void Configure(IApplicationBuilder application)
        {
            
        }


        public int Order => 3000;
    }
}
