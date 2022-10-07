using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Data;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository;
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
            services.AddDbContext<InvoiceContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IInvoiceSellService, InvoiceSellService>();
        }

        public void Configure(IApplicationBuilder application)
        {
        }

      
        public int Order => 3000;
    }
}
