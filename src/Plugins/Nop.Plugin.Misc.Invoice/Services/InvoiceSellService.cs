using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.Misc.Invoice.Domain;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public class InvoiceSellService : IInvoiceSellService
    {
        private readonly IRepository<InvoiceSell> _repository;

        public InvoiceSellService(IRepository<InvoiceSell> repository)
        {
            _repository = repository;
        }

        public void Add(InvoiceSell record)
        {
            throw new NotImplementedException();
        }
        public async Task<InvoiceSell> GetById(int id)
        {
          return await _repository.GetByIdAsync(id);
        }
    }
}
