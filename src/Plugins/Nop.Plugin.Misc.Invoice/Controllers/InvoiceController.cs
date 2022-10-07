using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Misc.Invoice.Controllers
{
    public class InvoiceController: BaseController
    {

      
        public async Task<IActionResult> Index()
        {
            

            return View("~/Plugins/Misc.Invoice/Views/Index.cshtml");
        }
        public async Task<IActionResult> Create()
        {


            return View("~/Plugins/Misc.Invoice/Views/Create.cshtml");
        }



    }
}
