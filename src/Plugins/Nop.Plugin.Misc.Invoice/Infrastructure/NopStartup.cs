using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
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
            services.AddScoped<IInvoiceSellService, InvoiceSellService>();
        }

           public void Configure(IApplicationBuilder application)
        {
        }

      
        public int Order => 3000;
    }
}
