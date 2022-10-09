using AutoMapper;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.Invoice.Models;
using Nop.Plugin.Misc.Invoice.Services;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Misc.Invoice.Controllers
{
    public class InvoiceController : BaseController
    {
        #region Fields
        private readonly IInvoiceSellService _invoiceSellService;
        private readonly IInvoiceSellUnitService _invoiceSellUinitService;
        private readonly IMapper _mapper;
        #endregion


        #region ctor
        public InvoiceController(IInvoiceSellService invoiceSellService, IMapper mapper, IInvoiceSellUnitService invoiceSellUinitService)
        {
            _invoiceSellService = invoiceSellService;
            _mapper = mapper;
            _invoiceSellUinitService = invoiceSellUinitService;
        }
        #endregion


        #region mothod
        public IActionResult Index()
        {


            return  View("~/Plugins/Misc.Invoice/Views/Index.cshtml");
        }

        public IActionResult Create(int id)
        {
            var model = new InvoiceSell();
            if (id > 0)
            {
                ViewBag.id = id;
                var item =  _invoiceSellService.GetById(id);

                model = _mapper.Map<InvoiceSell>(item);

                var units = _invoiceSellUinitService.GetById(id);
                List<InvoiceSellIUnit> unitsModels = new List<InvoiceSellIUnit>();
                foreach (var i in units)
                {
                    unitsModels.Add(_mapper.Map<Models.InvoiceSellIUnit>(i));

                } model.InvoiceSellIUnits = unitsModels;
            }
           


            return View("~/Plugins/Misc.Invoice/Views/Create.cshtml", model);
        }

        [HttpGet]
        public object InvoiceList(DataSourceLoadOptions loadOptions)
        {
            return _invoiceSellService.GetInvoices(loadOptions);
        }

        [HttpPost]
        public IActionResult Create([FromQuery] int id, [FromBody] Models.InvoiceSell model)
        {
            if (id == 0)
            {
                 NewInvoice(model);
            }
            else
            {
                 UpdateInvoice(id, model);
            }
            return Ok(model);
        }

        #endregion


        #region helper
        private void NewInvoice(InvoiceSell model)
        {
            var invoiceSell = _mapper.Map<Domain.InvoiceSell>(model);

             _invoiceSellService.Add(invoiceSell);

            if (model.InvoiceSellIUnits != null)
            {
                foreach (var i in model.InvoiceSellIUnits)
                {
                        var item = _mapper.Map<Domain.InvoiceSellUnit>(i);
                        item.InvoiceNo = invoiceSell.InvoiceNo;
                         _invoiceSellUinitService.Add(item);
                  

                }
            }
        }

        private void UpdateInvoice(int id, InvoiceSell model)
        {
            var invoiceSell = _mapper.Map<Domain.InvoiceSell>(model);

            _invoiceSellService.Update(id, invoiceSell);


            _invoiceSellUinitService.Delete(id);
            if (model.InvoiceSellIUnits != null)
            {
                foreach (var i in model.InvoiceSellIUnits)
                {
                   
                        var item = _mapper.Map<Domain.InvoiceSellUnit>(i);
                        item.InvoiceNo = invoiceSell.InvoiceNo;
                        _invoiceSellUinitService.Add(item);
                  

                }
            }
        }
        #endregion
    }
}
