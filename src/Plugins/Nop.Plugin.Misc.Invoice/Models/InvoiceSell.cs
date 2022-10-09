using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Models
{
    public class InvoiceSell
    {
        public string? DateH { get; set; }
        public DateTime DateG { get; set; }
        public long InvoiceNo { get; set; }
        public string? EName { get; set; }
        public string? MainContact1 { get; set; }
        public string? AName { get; set; }
        public string? InvoiceVatid { get; set; }
        public decimal? ClientVendorNo { get; set; }
        public List<InvoiceSellIUnit>? InvoiceSellIUnits { get; set; }
    }
}
