using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nop.Plugin.Misc.Invoice.Domain;

namespace Nop.Plugin.Misc.Invoice.Infrastructure.Repository
{
    public class InvoiceContext:DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {
        }
        public DbSet<InvoiceSell> InvoiceSell { get; set; }
        public DbSet<InvoiceSellUnit> InvoiceSellUnit { get; set; }

    }
}
