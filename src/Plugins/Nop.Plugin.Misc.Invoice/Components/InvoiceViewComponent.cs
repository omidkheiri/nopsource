using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.Invoice.Services;
using Nop.Web.Framework.Components;
using System;

namespace Nop.Plugin.Misc.Invoice.Components
{
    /// <summary>
    /// Represents view component to embed tracking script on pages
    /// </summary>
    [ViewComponent(Name = "MiscInvoice")]
    public class InvoiceViewComponent : NopViewComponent
    {
        #region Fields

        private readonly IInvoiceSellService _invoiceSellService;



        #endregion

        #region Ctor

        public InvoiceViewComponent(IInvoiceSellService invoiceSellService)
        {
            _invoiceSellService = invoiceSellService;
        }

        #endregion

        #region Methods




        public IViewComponentResult Invoke()
        {


            return View("~/Plugins/Misc.Invoice/Views/Index.cshtml");

        }

        #endregion
    }
}