using System;
using System.Linq;
using Nop.Plugin.Misc.Invoice.Domain;
using Nop.Plugin.Misc.Invoice.Infrastructure.Repository.Interface;

namespace Nop.Plugin.Misc.Invoice.Infrastructure.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private Nop_dbContext _repoContext;
        private IInvoiceSellRepository _invoiceSell;
        private IInvoiceSellUnitRepository _invoiceSellUnit;
        public IInvoiceSellRepository InvoiceSell
        {
            get
            {
                if (_invoiceSell == null)
                {
                    _invoiceSell = new InvoiceSellRepository(_repoContext);
                }
                return _invoiceSell;
            }
        }
        public IInvoiceSellUnitRepository InvoiceSellUnit
        {
            get
            {
                if (_invoiceSellUnit == null)
                {
                    _invoiceSellUnit = new InvoiceSellUnitRepository(_repoContext);
                }
                return _invoiceSellUnit;
            }
        }



        public RepositoryWrapper(Nop_dbContext repositoryContext) => _repoContext = repositoryContext;
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
