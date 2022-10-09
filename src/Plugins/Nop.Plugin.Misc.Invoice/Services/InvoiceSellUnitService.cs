using Nop.Plugin.Misc.Invoice.Domain;
using Nop.Plugin.Misc.Invoice.Infrastructure;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface;
using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public class InvoiceSellUnitService : IInvoiceSellUnitService
    {
        private readonly IRepositoryWrapper _context;


        public InvoiceSellUnitService(IRepositoryWrapper context)
        {
            _context = context;

        }

        public void Add(InvoiceSellUnit record)
        {
            try
            {

                _context.InvoiceSellUnit.Create(record);
                _context.Save();
            }
            catch (Exception ex)
            {
                var a = ex;
            }
        }

        public List<InvoiceSellUnit> GetById(long id)
        {
            return  _context.InvoiceSellUnit.FindByCondition(i => i.InvoiceNo == id).ToList();
        }
     

        public void Delete(long id)
        {
            
              var items=  _context.InvoiceSellUnit.FindByCondition(i=>i.InvoiceNo==id).ToList();
            foreach (var i in items)
            {
                _context.InvoiceSellUnit.Delete(i);
            }

              _context.Save();
           
        }
    }
}
