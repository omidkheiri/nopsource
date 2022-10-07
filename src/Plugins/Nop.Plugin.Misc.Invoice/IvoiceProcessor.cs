using Nop.Services.Common;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.Invoice
{
  public class IvoiceProcessor:BasePlugin, IMiscPlugin
  {
        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }
      

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
    }
}