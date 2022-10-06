using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
