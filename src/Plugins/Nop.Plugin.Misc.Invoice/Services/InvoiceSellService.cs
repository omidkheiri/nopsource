using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.Misc.Invoice.Domain;
using DevExtreme.AspNet.Data;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public class InvoiceSellService : IInvoiceSellService
    {
        private readonly InvoiceContext _context;

     
        public InvoiceSellService(InvoiceContext context)
        {
            _context = context;
           
        }

        public void Add(InvoiceSell record)
        {
            throw new NotImplementedException();
        }
        public async Task<InvoiceSell> GetById(int id)
        {
          return await _context.InvoiceSell.FirstOrDefaultAsync(i=>i.InvoiceNo==id);
        }
        public object GetInvoices(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.InvoiceSell, loadOptions);
        }
    }
}
