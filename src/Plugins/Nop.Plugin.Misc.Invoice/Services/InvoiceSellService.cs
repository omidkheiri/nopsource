using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Nop.Plugin.Misc.Invoice.Domain;
using Nop.Plugin.Misc.Invoice.Infrastructure;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public class InvoiceSellService : IInvoiceSellService
    {
        private readonly IRepositoryWrapper _context;


        public InvoiceSellService(IRepositoryWrapper context)
        {
            _context = context;

        }

        public void Add(InvoiceSell record)
        {

            record.UserNumber = "-";
             _context.InvoiceSell.Create(record);
             _context.Save();


        }
        public InvoiceSell GetById(int id) => _context.InvoiceSell.FindByCondition(i => i.InvoiceNo == id).First();
        public object GetInvoices(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.InvoiceSell.FindAll(), loadOptions);
        }

        public void Update(int id, InvoiceSell model)
        {
            var item = _context.InvoiceSell.FindByCondition(i => i.InvoiceNo == id).FirstOrDefault();

            if (item != null)
            {


                item.DateH = model.DateH;
                item.DateG = model.DateG;
                item.InvoiceNo = model.InvoiceNo;
                item.EName = model.EName;
                item.MainContact1 = model.MainContact1;
                item.AName = model.AName;
                item.InvoiceVatid = model.InvoiceVatid;
                item.ClientVendorNo = model.ClientVendorNo;



                item.SubNetTotalPlusTax = model.SubNetTotalPlusTax;
                item.TaxRate1Total = model.TaxRate1Total;
                item.SubNetTotal = model.SubNetTotal;
                item.SubTotalDiscount = model.SubTotalDiscount;
                item.SubQuantity = model.SubQuantity;
                item.AmountLeftAfterAllBills = model.AmountLeftAfterAllBills;
                item.AmountLeft = model.AmountLeft;

        









        _context.InvoiceSell.Update(item);

                _context.Save();
            }
           
        }

   

   
    }
}

