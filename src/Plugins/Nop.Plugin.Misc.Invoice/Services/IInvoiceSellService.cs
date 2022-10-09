using DevExtreme.AspNet.Mvc;
using Nop.Plugin.Misc.Invoice.Domain;
using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Services
{
    public interface IInvoiceSellService
    {
        void Add(InvoiceSell record);
        InvoiceSell GetById(int id);
        object GetInvoices(DataSourceLoadOptions loadOptions);
        void Update(int id, InvoiceSell record);
    }
}
