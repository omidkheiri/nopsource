using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Misc.Invoice.Domain;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface;

namespace Nop.Plugin.Misc.Invoice.Infrastructure.Repository
{
    public class InvoiceSellRepository : RepositoryBase<InvoiceSell>, IInvoiceSellRepository
    {
        public InvoiceSellRepository(Nop_dbContext repositoryContext) : base(repositoryContext)
        {
        }

   
    }
}
