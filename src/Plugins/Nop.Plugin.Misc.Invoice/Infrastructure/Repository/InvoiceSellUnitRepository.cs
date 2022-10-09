using Nop.Plugin.Misc.Invoice.Domain;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Nop.Plugin.Misc.Invoice.Infrastructure.Repository
{
    public class InvoiceSellUnitRepository : RepositoryBase<InvoiceSellUnit>, IInvoiceSellUnitRepository
    {
        public InvoiceSellUnitRepository(Nop_dbContext repositoryContext) : base(repositoryContext)
        {
        }

   
    }
}
