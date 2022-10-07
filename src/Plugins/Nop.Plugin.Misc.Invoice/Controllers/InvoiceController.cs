﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Nop.Data;
using Nop.Plugin.Misc.Invoice.Services;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Misc.Invoice.Controllers
{
    public class InvoiceController: BaseController
    {
        private readonly IInvoiceSellService _invoiceSellService;

        public InvoiceController(IInvoiceSellService invoiceSellService)
        {
            _invoiceSellService = invoiceSellService;
        }

        public async Task<IActionResult> Index()
        {
           

            return View("~/Plugins/Misc.Invoice/Views/Index.cshtml");
        }
        public async Task<IActionResult> Create()
        {


            return View("~/Plugins/Misc.Invoice/Views/Create.cshtml");
        }

        [HttpGet]
        public object InvoiceList(DataSourceLoadOptions loadOptions)
        {
            return _invoiceSellService.GetInvoices( loadOptions );
        }



    }
}
