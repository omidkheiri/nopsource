using Nop.Plugin.Misc.Invoice.Domain;
using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public interface IInvoiceSellService
    {
        void Add(InvoiceSell record);
        Task<InvoiceSell> GetById(int id);
    }
}
