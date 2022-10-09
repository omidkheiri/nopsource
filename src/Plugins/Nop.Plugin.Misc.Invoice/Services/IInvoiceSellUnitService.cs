using Nop.Plugin.Misc.Invoice.Domain;

using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public interface IInvoiceSellUnitService
    {
     void    Add(InvoiceSellUnit record);
        List<InvoiceSellUnit> GetById(long id);
        void Delete(long id);
    }
}
