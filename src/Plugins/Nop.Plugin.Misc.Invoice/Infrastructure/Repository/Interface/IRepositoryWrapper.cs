using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface
{
    public interface IRepositoryWrapper
    {
        IInvoiceSellRepository InvoiceSell { get; }
        IInvoiceSellUnitRepository InvoiceSellUnit { get; }
        void Save();
    }
}
